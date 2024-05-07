using System.Reflection.Emit;

namespace AB_game
{
    public partial class Welcome : Form
    {
        public string player;
        public string mode;
        public Welcome()
        {
            InitializeComponent();
        }

        public void playerName_TextChanged(object sender, EventArgs e)
        {
            player = playerName.Text;
            if (playerName.Text.Length >= 1 && codeMaker.Checked == true || codeBreaker.Checked == true)
            { Start.Enabled = true; }
            else
            { Start.Enabled = false; }
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            databaseLogs dbl = new databaseLogs();
            dbl.ShowDialog();
        }

        private void codeMaker_CheckedChanged(object sender, EventArgs e)
        {
            if (codeMaker.Checked == true)
            {
                mode = "Code Maker";
            }
        }

        private void codeBreaker_CheckedChanged(object sender, EventArgs e)
        {
            if (codeBreaker.Checked == true)
            {
                mode = "Code Breaker";
            }
        }



        private void Start_Click(object sender, EventArgs e)
        {
            CodeMakerHomepage.setCodeNameOne(mode);
            CodeBreakerHomepage.setCodeNameTwo(mode);
            CodeBreakerHomepage.setPlayerName(player);
            CodeMakerHomepage.setPlayerName(player);

            if (mode.Equals("Code Maker"))
            {
                CodeMakerHomepage homepage1 = new CodeMakerHomepage();
                homepage1.ShowDialog();
            }
            else if (mode.Equals("Code Breaker"))
            {
                CodeBreakerHomepage homepage2 = new CodeBreakerHomepage();
                homepage2.ShowDialog();
            }

        }

        private void makerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeMaker.Checked = true;
            mode = "Code Maker";
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeBreaker.Checked == true || codeMaker.Checked == true && playerName.Text.Length >= 1)
            {
             //   Start.Enabled = true;
                if (mode.Equals("Code Maker"))
                {
                    CodeMakerHomepage homepage1 = new CodeMakerHomepage();
                    homepage1.ShowDialog();
                }
                else if (mode.Equals("Code Breaker"))
                {
                    CodeBreakerHomepage homepage2 = new CodeBreakerHomepage();
                    homepage2.ShowDialog();
                }

            }
            else
            {
              //  Start.Enabled = false;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CodebreakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBreaker.Checked = true;
            mode = "Code Breaker";
        }

        private void databaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            databaseLogs dbl = new databaseLogs();
            dbl.ShowDialog();
        }

        private void beginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (codeBreaker.Checked == true || codeMaker.Checked == true && playerName.Text.Length >= 1)
            {
//                Start.Enabled = true;
                if (mode.Equals("Code Maker"))
                {
                    CodeMakerHomepage homepage1 = new CodeMakerHomepage();
                    homepage1.ShowDialog();
                }
                else if (mode.Equals("Code Breaker"))
                {
                    CodeBreakerHomepage homepage2 = new CodeBreakerHomepage();
                    homepage2.ShowDialog();
                }

            }
            else
            {
  //              Start.Enabled = false;
            }
        }

        private void codeMakerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            codeMaker.Checked = true;
            mode = "Code Maker";
        }

        private void codeBreakerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            codeBreaker.Checked = true;
            mode = "Code Breaker";
        }

        private void viewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseLogs dbl = new databaseLogs();
            dbl.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
