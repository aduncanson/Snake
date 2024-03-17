namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlGrid = new Panel();
            nudColumns = new NumericUpDown();
            lblColumns = new Label();
            lblRows = new Label();
            nudRows = new NumericUpDown();
            btnStart = new Button();
            lblSpeed = new Label();
            nudSpeed = new NumericUpDown();
            lblPauseAndResume = new Label();
            lblHighScore = new Label();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeed).BeginInit();
            SuspendLayout();
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.Location = new Point(12, 70);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(843, 365);
            pnlGrid.TabIndex = 0;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(73, 7);
            nudColumns.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nudColumns.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(58, 23);
            nudColumns.TabIndex = 1;
            nudColumns.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblColumns
            // 
            lblColumns.AutoSize = true;
            lblColumns.Location = new Point(12, 9);
            lblColumns.Name = "lblColumns";
            lblColumns.Size = new Size(55, 15);
            lblColumns.TabIndex = 2;
            lblColumns.Text = "Columns";
            // 
            // lblRows
            // 
            lblRows.AutoSize = true;
            lblRows.Location = new Point(12, 38);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(35, 15);
            lblRows.TabIndex = 4;
            lblRows.Text = "Rows";
            // 
            // nudRows
            // 
            nudRows.Location = new Point(73, 36);
            nudRows.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudRows.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(58, 23);
            nudRows.TabIndex = 3;
            nudRows.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.Location = new Point(780, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(174, 9);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(39, 15);
            lblSpeed.TabIndex = 7;
            lblSpeed.Text = "Speed";
            // 
            // nudSpeed
            // 
            nudSpeed.Location = new Point(235, 7);
            nudSpeed.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudSpeed.Name = "nudSpeed";
            nudSpeed.Size = new Size(58, 23);
            nudSpeed.TabIndex = 6;
            nudSpeed.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblPauseAndResume
            // 
            lblPauseAndResume.AutoSize = true;
            lblPauseAndResume.Location = new Point(668, 9);
            lblPauseAndResume.Name = "lblPauseAndResume";
            lblPauseAndResume.Size = new Size(106, 30);
            lblPauseAndResume.TabIndex = 8;
            lblPauseAndResume.Text = "Press 'p' to pause.\r\nPress 'r' to resume.";
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHighScore.Location = new Point(571, 9);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(82, 15);
            lblHighScore.TabIndex = 9;
            lblHighScore.Text = "High Score: {}";
            lblHighScore.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 447);
            Controls.Add(lblHighScore);
            Controls.Add(lblPauseAndResume);
            Controls.Add(lblSpeed);
            Controls.Add(nudSpeed);
            Controls.Add(btnStart);
            Controls.Add(lblRows);
            Controls.Add(nudRows);
            Controls.Add(lblColumns);
            Controls.Add(nudColumns);
            Controls.Add(pnlGrid);
            Name = "Form1";
            Text = "Snake";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlGrid;
        private NumericUpDown nudColumns;
        private Label lblColumns;
        private Label lblRows;
        private NumericUpDown nudRows;
        private Button btnStart;
        private Label lblSpeed;
        private NumericUpDown nudSpeed;
        private Label lblPauseAndResume;
        private Label lblHighScore;
    }
}