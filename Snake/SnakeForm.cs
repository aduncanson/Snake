using System.Xml.Linq;

namespace Snake
{
    public partial class SnakeForm : Form
    {
        private int[,] snakeCells = new int[25, 40];
        public SnakeForm()
        {
            InitializeComponent();

            snakeCells[0, 0] = 1;
        }
    }
}