namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Panel> _snake = new();
        private readonly List<List<Panel>> _grid = new();
        private int _rows;
        private int _columns;
        private readonly int _dimension = 30;
        private int _rowIndex;
        private int _columnIndex;
        private Size _cellSize;
        private bool _started = false;
        private Panel _food;
        private System.Windows.Forms.Timer _timer;
        private int _highScore;
        private enum Direction { None, Left, Right, Up, Down };
        private Direction _direction = Direction.None;
        private Direction _nextDirection = Direction.None;

        public Form1()
        {
            InitializeComponent();

            _cellSize = new Size(_dimension, _dimension);
        }

        private void SetTimer()
        {
            _timer = new()
            {
                Interval = (int)(nudSpeed.Value / 100 * 1000)
            };
            _timer.Tick += new EventHandler(Timer_Tick);
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!_started) { return; }

            RedrawGrid();
        }

        private void RedrawGrid()
        {
            if (_nextDirection == Direction.None) { return; }

            _direction = _nextDirection;

            var snakeHead = _snake.First();

            switch (_direction)
            {
                case Direction.Left:
                    _columnIndex -= 1; break;
                case Direction.Right:
                    _columnIndex += 1; break;
                case Direction.Up:
                    _rowIndex -= 1; break;
                case Direction.Down:
                    _rowIndex += 1; break;
            }

            _rowIndex = Mod(_rowIndex, _rows);
            _columnIndex = Mod(_columnIndex, _columns);

            var newHead = _grid[_columnIndex][_rowIndex];

            // Check if snake has collided with itself
            if (_snake.Any(s => s == newHead))
            {
                _timer.Stop();
                MessageBox.Show($"End!{Environment.NewLine}Score: {_snake.Count - 1}");
                ResetGrid();
                return;
            }

            _snake.Insert(0, newHead);

            // Check if snake has eaten food
            if (_food == newHead)
            {
                DrawFood();
            }
            else
            {
                var snakeTail = _snake.Last();
                snakeTail.BackColor = Color.Black;
                _snake.Remove(snakeTail);
            }

            DrawSnake();
        }

        private void LoadGrid()
        {
            foreach (int i in Enumerable.Range(0, _columns))
            {
                _grid.Add(new List<Panel>());
                foreach (int j in Enumerable.Range(0, _rows))
                {
                    Panel p = new()
                    {
                        Size = _cellSize,
                        Location = new Point(i * _dimension, j * _dimension),
                        BackColor = Color.Black,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    _grid.Last().Add(p);
                }
            }
            pnlGrid.Controls.AddRange(_grid.SelectMany(p => p).ToArray());
        }

        private void DrawSnake()
        {
            foreach (var coord in _snake)
            {
                coord.BackColor = Color.White;
            }

            _snake[0].BackColor = Color.DarkOrange;

            if (_snake.Count == 1) { return; }

            for (int i = 1; i < _snake.Count; i++)
            {
                _snake[i].BackColor = (i % 2 == 0) ? Color.White : Color.Yellow;
            }
        }

        private void DrawFood()
        {
            _food = _grid.SelectMany(p => p).Where(p => p.BackColor == Color.Black).OrderBy(x => Guid.NewGuid()).First();

            _food.BackColor = Color.LightGreen;
        }

        private int Mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        private void ResetGrid()
        {
            _timer.Stop();

            if (_highScore < _snake.Count - 1)
            {
                _highScore = _snake.Count - 1;
                lblHighScore.Text = $"High Score: {_snake.Count - 1}";
                lblHighScore.Visible = true;
            }

            _snake.Select(s => { s.BackColor = Color.Black; return s; }).ToList();
            _food.BackColor = Color.Black;
            _grid.Clear();
            _snake.Clear();
            pnlGrid.Controls.Clear();

            nudColumns.Enabled = true;
            nudRows.Enabled = true;
            nudSpeed.Enabled = true;
            btnStart.Enabled = true;
            _started = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_started)
            {
                _started = true;
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (_direction == Direction.Right) { return; }
                    _nextDirection = Direction.Left; break;
                case Keys.Right:
                    if (_direction == Direction.Left) { return; }
                    _nextDirection = Direction.Right; break;
                case Keys.Up:
                    if (_direction == Direction.Down) { return; }
                    _nextDirection = Direction.Up; break;
                case Keys.Down:
                    if (_direction == Direction.Up) { return; }
                    _nextDirection = Direction.Down; break;
                case Keys.P:
                    _timer.Stop();
                    break;
                case Keys.R:
                    _timer.Start();
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            nudRows.Enabled = false;
            nudColumns.Enabled = false;
            nudSpeed.Enabled = false;
            btnStart.Enabled = false;

            _rows = (int)nudRows.Value;
            _columns = (int)nudColumns.Value;

            LoadGrid();

            // create snake starting position
            var rnd = new Random();
            _rowIndex = rnd.Next(0, _rows);
            _columnIndex = rnd.Next(0, _columns);
            _snake.Add(_grid[_columnIndex][_rowIndex]);

            DrawSnake();
            DrawFood();
            SetTimer();
        }
    }
}