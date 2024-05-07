namespace AB_game
{
    partial class Welcome
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            playerName = new TextBox();
            Start = new Button();
            ModeBox = new GroupBox();
            codeBreaker = new RadioButton();
            codeMaker = new RadioButton();
            btnDatabase = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            beginToolStripMenuItem1 = new ToolStripMenuItem();
            modeToolStripMenuItem = new ToolStripMenuItem();
            codeMakerToolStripMenuItem1 = new ToolStripMenuItem();
            codeBreakerToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            viewDatabaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            beginToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            CodemakerToolStripMenuItem = new ToolStripMenuItem();
            CodebreakerToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem1 = new ToolStripMenuItem();
            ModeBox.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 60);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(651, 50);
            label1.TabIndex = 0;
            label1.Text = "Developers Emily Fasano, Favour Salako, and Emily Treharn of group 14 \r\ninvite you to play the AB game. ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 284);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter your name:";
            // 
            // playerName
            // 
            playerName.Location = new Point(445, 277);
            playerName.Name = "playerName";
            playerName.Size = new Size(100, 33);
            playerName.TabIndex = 2;
            playerName.TextChanged += playerName_TextChanged;
            // 
            // Start
            // 
            Start.Enabled = false;
            Start.FlatStyle = FlatStyle.Popup;
            Start.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start.Location = new Point(424, 374);
            Start.Name = "Start";
            Start.Size = new Size(95, 37);
            Start.TabIndex = 3;
            Start.Text = "Begin";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // ModeBox
            // 
            ModeBox.Controls.Add(codeBreaker);
            ModeBox.Controls.Add(codeMaker);
            ModeBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ModeBox.Location = new Point(349, 150);
            ModeBox.Name = "ModeBox";
            ModeBox.Size = new Size(239, 113);
            ModeBox.TabIndex = 4;
            ModeBox.TabStop = false;
            ModeBox.Text = "Choose your mode";
            // 
            // codeBreaker
            // 
            codeBreaker.AutoSize = true;
            codeBreaker.Location = new Point(23, 75);
            codeBreaker.Name = "codeBreaker";
            codeBreaker.Size = new Size(138, 29);
            codeBreaker.TabIndex = 1;
            codeBreaker.TabStop = true;
            codeBreaker.Text = "Code Breaker";
            codeBreaker.UseVisualStyleBackColor = true;
            codeBreaker.CheckedChanged += codeBreaker_CheckedChanged;
            // 
            // codeMaker
            // 
            codeMaker.AutoSize = true;
            codeMaker.Location = new Point(22, 37);
            codeMaker.Name = "codeMaker";
            codeMaker.Size = new Size(127, 29);
            codeMaker.TabIndex = 0;
            codeMaker.TabStop = true;
            codeMaker.Text = "Code Maker";
            codeMaker.UseVisualStyleBackColor = true;
            codeMaker.CheckedChanged += codeMaker_CheckedChanged;
            // 
            // btnDatabase
            // 
            btnDatabase.Location = new Point(626, 380);
            btnDatabase.Name = "btnDatabase";
            btnDatabase.Size = new Size(202, 47);
            btnDatabase.TabIndex = 6;
            btnDatabase.Text = "View Database";
            btnDatabase.UseVisualStyleBackColor = true;
            btnDatabase.Click += btnDatabase_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { beginToolStripMenuItem1, modeToolStripMenuItem, toolStripSeparator2, viewDatabaseToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(183, 120);
            // 
            // beginToolStripMenuItem1
            // 
            beginToolStripMenuItem1.Name = "beginToolStripMenuItem1";
            beginToolStripMenuItem1.Size = new Size(182, 26);
            beginToolStripMenuItem1.Text = "Begin";
            beginToolStripMenuItem1.Click += beginToolStripMenuItem1_Click;
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codeMakerToolStripMenuItem1, codeBreakerToolStripMenuItem1 });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(182, 26);
            modeToolStripMenuItem.Text = "Mode";
            // 
            // codeMakerToolStripMenuItem1
            // 
            codeMakerToolStripMenuItem1.Name = "codeMakerToolStripMenuItem1";
            codeMakerToolStripMenuItem1.Size = new Size(173, 26);
            codeMakerToolStripMenuItem1.Text = "Code Maker";
            codeMakerToolStripMenuItem1.Click += codeMakerToolStripMenuItem1_Click;
            // 
            // codeBreakerToolStripMenuItem1
            // 
            codeBreakerToolStripMenuItem1.Name = "codeBreakerToolStripMenuItem1";
            codeBreakerToolStripMenuItem1.Size = new Size(173, 26);
            codeBreakerToolStripMenuItem1.Text = "Code Breaker";
            codeBreakerToolStripMenuItem1.Click += codeBreakerToolStripMenuItem1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(179, 6);
            // 
            // viewDatabaseToolStripMenuItem
            // 
            viewDatabaseToolStripMenuItem.Name = "viewDatabaseToolStripMenuItem";
            viewDatabaseToolStripMenuItem.Size = new Size(182, 26);
            viewDatabaseToolStripMenuItem.Text = "View Database";
            viewDatabaseToolStripMenuItem.Click += viewDatabaseToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(179, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(182, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, databaseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 29);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beginToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // beginToolStripMenuItem
            // 
            beginToolStripMenuItem.Name = "beginToolStripMenuItem";
            beginToolStripMenuItem.Size = new Size(119, 26);
            beginToolStripMenuItem.Text = "Begin";
            beginToolStripMenuItem.Click += beginToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(116, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(119, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CodemakerToolStripMenuItem, CodebreakerToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(62, 25);
            editToolStripMenuItem.Text = "Mode";
            // 
            // CodemakerToolStripMenuItem
            // 
            CodemakerToolStripMenuItem.Name = "CodemakerToolStripMenuItem";
            CodemakerToolStripMenuItem.Size = new Size(173, 26);
            CodemakerToolStripMenuItem.Text = "Code Maker";
            CodemakerToolStripMenuItem.Click += makerToolStripMenuItem_Click;
            // 
            // CodebreakerToolStripMenuItem
            // 
            CodebreakerToolStripMenuItem.Name = "CodebreakerToolStripMenuItem";
            CodebreakerToolStripMenuItem.Size = new Size(173, 26);
            CodebreakerToolStripMenuItem.Text = "Code Breaker";
            CodebreakerToolStripMenuItem.Click += CodebreakerToolStripMenuItem_Click;
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { databaseToolStripMenuItem1 });
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(56, 25);
            databaseToolStripMenuItem.Text = "View";
            // 
            // databaseToolStripMenuItem1
            // 
            databaseToolStripMenuItem1.Name = "databaseToolStripMenuItem1";
            databaseToolStripMenuItem1.Size = new Size(144, 26);
            databaseToolStripMenuItem1.Text = "Database";
            databaseToolStripMenuItem1.Click += databaseToolStripMenuItem1_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            Controls.Add(btnDatabase);
            Controls.Add(ModeBox);
            Controls.Add(Start);
            Controls.Add(playerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Welcome";
            Text = "Welcome";
            ModeBox.ResumeLayout(false);
            ModeBox.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox playerName;
        private Button Start;
        private GroupBox ModeBox;
        private RadioButton codeBreaker;
        private RadioButton codeMaker;
        private Button btnDatabase;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem beginToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem CodemakerToolStripMenuItem;
        private ToolStripMenuItem CodebreakerToolStripMenuItem;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem databaseToolStripMenuItem1;
        private ToolStripMenuItem beginToolStripMenuItem1;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem codeMakerToolStripMenuItem1;
        private ToolStripMenuItem codeBreakerToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem viewDatabaseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}
