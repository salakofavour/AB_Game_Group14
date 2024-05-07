namespace AB_game
{
    partial class CodeBreakerHomepage
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
            Hint = new TextBox();
            label1 = new Label();
            guessCount2 = new Label();
            computersGuess = new Label();
            label3 = new Label();
            compute = new Button();
            errorInput = new Label();
            newGame = new Button();
            breakerTimer = new System.Windows.Forms.Timer(components);
            timeSpent2 = new Label();
            dataGridView1 = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            guess = new DataGridViewTextBoxColumn();
            hintList = new DataGridViewTextBoxColumn();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            computeToolStripMenuItem1 = new ToolStripMenuItem();
            newGameToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            computeToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Hint
            // 
            Hint.Location = new Point(173, 121);
            Hint.MaxLength = 4;
            Hint.Name = "Hint";
            Hint.Size = new Size(66, 23);
            Hint.TabIndex = 0;
            Hint.TextChanged += HintA_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 124);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Input Hint Here:";
            // 
            // guessCount2
            // 
            guessCount2.AutoSize = true;
            guessCount2.Location = new Point(56, 65);
            guessCount2.Name = "guessCount2";
            guessCount2.Size = new Size(86, 15);
            guessCount2.TabIndex = 2;
            guessCount2.Text = "Guess Count: 0";
            // 
            // computersGuess
            // 
            computersGuess.AutoSize = true;
            computersGuess.Location = new Point(214, 242);
            computersGuess.Name = "computersGuess";
            computersGuess.Size = new Size(0, 15);
            computersGuess.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 306);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 4;
            label3.Text = "Computers Guess:";
            // 
            // compute
            // 
            compute.Location = new Point(101, 238);
            compute.Name = "compute";
            compute.Size = new Size(75, 23);
            compute.TabIndex = 5;
            compute.Text = "Compute";
            compute.UseVisualStyleBackColor = true;
            compute.Click += compute_Click;
            // 
            // errorInput
            // 
            errorInput.AutoSize = true;
            errorInput.Location = new Point(208, 52);
            errorInput.Name = "errorInput";
            errorInput.Size = new Size(0, 15);
            errorInput.TabIndex = 9;
            // 
            // newGame
            // 
            newGame.Location = new Point(152, 350);
            newGame.Name = "newGame";
            newGame.Size = new Size(75, 23);
            newGame.TabIndex = 16;
            newGame.Text = "New Game";
            newGame.UseVisualStyleBackColor = true;
            newGame.Click += newGame_Click;
            // 
            // breakerTimer
            // 
            breakerTimer.Interval = 1000;
            breakerTimer.Tick += breakerTimer_Tick;
            // 
            // timeSpent2
            // 
            timeSpent2.AutoSize = true;
            timeSpent2.Location = new Point(188, 67);
            timeSpent2.Name = "timeSpent2";
            timeSpent2.Size = new Size(114, 15);
            timeSpent2.TabIndex = 17;
            timeSpent2.Text = "Time Spent: 00:00:00";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { number, guess, hintList });
            dataGridView1.Location = new Point(446, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 403);
            dataGridView1.TabIndex = 20;
            // 
            // number
            // 
            number.HeaderText = "#";
            number.Name = "number";
            // 
            // guess
            // 
            guess.HeaderText = "Guess";
            guess.Name = "guess";
            // 
            // hintList
            // 
            hintList.HeaderText = "Hint";
            hintList.Name = "hintList";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 29);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 21;
            label2.Text = "Code Breaker";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { computeToolStripMenuItem1, newGameToolStripMenuItem1, toolStripSeparator2, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(158, 88);
            // 
            // computeToolStripMenuItem1
            // 
            computeToolStripMenuItem1.Name = "computeToolStripMenuItem1";
            computeToolStripMenuItem1.Size = new Size(157, 26);
            computeToolStripMenuItem1.Text = "Compute";
            computeToolStripMenuItem1.Click += computeToolStripMenuItem1_Click;
            // 
            // newGameToolStripMenuItem1
            // 
            newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            newGameToolStripMenuItem1.Size = new Size(157, 26);
            newGameToolStripMenuItem1.Text = "New Game";
            newGameToolStripMenuItem1.Click += newGameToolStripMenuItem1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(154, 6);
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
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { computeToolStripMenuItem, newGameToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // computeToolStripMenuItem
            // 
            computeToolStripMenuItem.Name = "computeToolStripMenuItem";
            computeToolStripMenuItem.Size = new Size(157, 26);
            computeToolStripMenuItem.Text = "Compute";
            computeToolStripMenuItem.Click += computeToolStripMenuItem_Click;
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(157, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(157, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // CodeBreakerHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(timeSpent2);
            Controls.Add(newGame);
            Controls.Add(errorInput);
            Controls.Add(compute);
            Controls.Add(label3);
            Controls.Add(computersGuess);
            Controls.Add(guessCount2);
            Controls.Add(label1);
            Controls.Add(Hint);
            MainMenuStrip = menuStrip1;
            Name = "CodeBreakerHomepage";
            Text = "CodeBreakerHomepage";
            Load += CodeBreakerHomepage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Hint;
        private Label label1;
        private Label guessCount2;
        private Label computersGuess;
        private Label label3;
        private Button compute;
        private Label errorInput;
        private Button newGame;
        private System.Windows.Forms.Timer breakerTimer;
        private Label timeSpent2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn guess;
        private DataGridViewTextBoxColumn hintList;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem computeToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem computeToolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}