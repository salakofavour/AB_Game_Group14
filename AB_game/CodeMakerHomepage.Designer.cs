namespace AB_game
{
    partial class CodeMakerHomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            checkInput = new Button();
            Restart = new Button();
            practice = new Label();
            input1 = new TextBox();
            input2 = new TextBox();
            input3 = new TextBox();
            input4 = new TextBox();
            Anumber = new Label();
            incompleteInput = new Label();
            guessCount = new Label();
            timeSpent = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            Guess = new DataGridViewTextBoxColumn();
            hintList = new DataGridViewTextBoxColumn();
            GameFinalScore = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            checkToolStripMenuItem1 = new ToolStripMenuItem();
            newGameToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            checkToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // checkInput
            // 
            checkInput.FlatStyle = FlatStyle.Popup;
            checkInput.Font = new Font("Segoe UI", 12F);
            checkInput.Location = new Point(62, 272);
            checkInput.Name = "checkInput";
            checkInput.Size = new Size(100, 50);
            checkInput.TabIndex = 4;
            checkInput.Text = "Check";
            checkInput.UseVisualStyleBackColor = true;
            checkInput.Click += checkInput_Click;
            // 
            // Restart
            // 
            Restart.FlatStyle = FlatStyle.Popup;
            Restart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Restart.Location = new Point(219, 272);
            Restart.Name = "Restart";
            Restart.Size = new Size(100, 50);
            Restart.TabIndex = 6;
            Restart.Text = "New Game";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // practice
            // 
            practice.AutoSize = true;
            practice.Location = new Point(62, 181);
            practice.Name = "practice";
            practice.Size = new Size(205, 15);
            practice.TabIndex = 7;
            practice.Text = "Display randomly generated numbers";
            // 
            // input1
            // 
            input1.Font = new Font("Segoe UI", 12F);
            input1.Location = new Point(114, 72);
            input1.MaximumSize = new Size(40, 80);
            input1.MaxLength = 1;
            input1.MinimumSize = new Size(30, 60);
            input1.Name = "input1";
            input1.Size = new Size(40, 29);
            input1.TabIndex = 8;
            input1.TextChanged += input1_TextChanged;
            // 
            // input2
            // 
            input2.Font = new Font("Segoe UI", 12F);
            input2.Location = new Point(185, 72);
            input2.MaximumSize = new Size(40, 80);
            input2.MaxLength = 1;
            input2.MinimumSize = new Size(30, 60);
            input2.Name = "input2";
            input2.Size = new Size(40, 29);
            input2.TabIndex = 9;
            input2.TextChanged += input2_TextChanged;
            // 
            // input3
            // 
            input3.Font = new Font("Segoe UI", 12F);
            input3.Location = new Point(255, 72);
            input3.MaximumSize = new Size(40, 80);
            input3.MaxLength = 1;
            input3.MinimumSize = new Size(30, 60);
            input3.Name = "input3";
            input3.Size = new Size(40, 29);
            input3.TabIndex = 10;
            input3.TextChanged += input3_TextChanged;
            // 
            // input4
            // 
            input4.Font = new Font("Segoe UI", 12F);
            input4.Location = new Point(329, 72);
            input4.MaximumSize = new Size(40, 80);
            input4.MaxLength = 1;
            input4.MinimumSize = new Size(30, 60);
            input4.Name = "input4";
            input4.Size = new Size(40, 29);
            input4.TabIndex = 11;
            input4.TextChanged += input4_TextChanged;
            // 
            // Anumber
            // 
            Anumber.AutoSize = true;
            Anumber.Location = new Point(292, 181);
            Anumber.Name = "Anumber";
            Anumber.Size = new Size(15, 15);
            Anumber.TabIndex = 12;
            Anumber.Text = "A";
            // 
            // incompleteInput
            // 
            incompleteInput.AutoSize = true;
            incompleteInput.Location = new Point(183, 30);
            incompleteInput.Name = "incompleteInput";
            incompleteInput.Size = new Size(0, 15);
            incompleteInput.TabIndex = 14;
            // 
            // guessCount
            // 
            guessCount.AutoSize = true;
            guessCount.Location = new Point(73, 30);
            guessCount.Name = "guessCount";
            guessCount.Size = new Size(50, 15);
            guessCount.TabIndex = 15;
            guessCount.Text = "Guess: 0";
            // 
            // timeSpent
            // 
            timeSpent.AutoSize = true;
            timeSpent.Location = new Point(142, 54);
            timeSpent.Name = "timeSpent";
            timeSpent.Size = new Size(114, 15);
            timeSpent.TabIndex = 16;
            timeSpent.Text = "Time Spent: 00:00:00";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { number, Guess, hintList });
            dataGridView1.Location = new Point(418, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 377);
            dataGridView1.TabIndex = 17;
            // 
            // number
            // 
            number.HeaderText = "#";
            number.Name = "number";
            // 
            // Guess
            // 
            Guess.HeaderText = "Guess";
            Guess.Name = "Guess";
            // 
            // hintList
            // 
            hintList.HeaderText = "Hint";
            hintList.Name = "hintList";
            // 
            // GameFinalScore
            // 
            GameFinalScore.AutoSize = true;
            GameFinalScore.Location = new Point(174, 369);
            GameFinalScore.Name = "GameFinalScore";
            GameFinalScore.Size = new Size(38, 15);
            GameFinalScore.TabIndex = 18;
            GameFinalScore.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 369);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 19;
            label1.Text = "Final Score:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { checkToolStripMenuItem1, newGameToolStripMenuItem1, toolStripSeparator1, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(158, 88);
            // 
            // checkToolStripMenuItem1
            // 
            checkToolStripMenuItem1.Name = "checkToolStripMenuItem1";
            checkToolStripMenuItem1.Size = new Size(157, 26);
            checkToolStripMenuItem1.Text = "Check";
            checkToolStripMenuItem1.Click += checkToolStripMenuItem1_Click;
            // 
            // newGameToolStripMenuItem1
            // 
            newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            newGameToolStripMenuItem1.Size = new Size(157, 26);
            newGameToolStripMenuItem1.Text = "New Game";
            newGameToolStripMenuItem1.Click += newGameToolStripMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(154, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(157, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 29);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkToolStripMenuItem, newGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // checkToolStripMenuItem
            // 
            checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            checkToolStripMenuItem.Size = new Size(157, 26);
            checkToolStripMenuItem.Text = "Check";
            checkToolStripMenuItem.Click += checkToolStripMenuItem_Click;
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(157, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(157, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // CodeMakerHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(GameFinalScore);
            Controls.Add(dataGridView1);
            Controls.Add(timeSpent);
            Controls.Add(guessCount);
            Controls.Add(incompleteInput);
            Controls.Add(Anumber);
            Controls.Add(input4);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(practice);
            Controls.Add(Restart);
            Controls.Add(checkInput);
            MainMenuStrip = menuStrip1;
            Name = "CodeMakerHomepage";
            Text = "Homepage";
            Load += Homepage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button checkInput;
        private Button Restart;
        private Label practice;
        private TextBox input1;
        private TextBox input2;
        private TextBox input3;
        private TextBox input4;
        private Label Anumber;
        private Label incompleteInput;
        private Label guessCount;
        private Label timeSpent;
        private System.Windows.Forms.Timer gameTimer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn Guess;
        private DataGridViewTextBoxColumn hintList;
        private Label finalScoreCalcs;
        private Label GameFinalScore;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem checkToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem checkToolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}