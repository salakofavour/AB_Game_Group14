using CIS3433;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AB_game
{
    public partial class CodeBreakerHomepage : Form
    {
        string previousGuess;
        string hintGiven;
        string timeholderDb2;
        public static string playerName;
        public static string mode;
        string dateTime = DateTime.Now.ToString();
        int checkCount = 0;
        int secondstaken = 0;
        string secretNumber;//no placeholder
        string allComputerGuessses;
        float gameScore;
        string computersrandomGuess;
        List<string> newCombinationResult = new List<string>();

        Database dataBase = new Database();
        Class1 CountAB = new Class1();
        Class2 scoreClass = new Class2();
        const string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;";
        public CodeBreakerHomepage()
        {
            InitializeComponent();
            newCombinationResult = GenerateAllCombinations();
            computersGuess.Text = "2368"; //displays the first computer's guess, you can make this random values using rand() or you can change the hardcoded string this to any 4 non-repeating values


        }

        private List<string> GenerateAllCombinations()
        {
            var combinations = new List<string>();

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j == i) continue;
                    for (int k = 0; k <= 9; k++)
                    {
                        if (k == i || k == j) continue;
                        for (int l = 0; l <= 9; l++)
                        {
                            if (l == i || l == j || l == k) continue;
                            combinations.Add($"{i}{j}{k}{l}");
                        }
                    }
                }
            }

            return combinations;
        }

        public string breakerCalculation(string preGuess, string providedHint)
        {
            string hints = providedHint;

            Random rand = new Random();

            string joinRandoms = ""; //reset the value before each run

            List<string> validGuesses = new List<string>();
            List<string> holderGuesses = new List<string>();

            foreach (var guess in newCombinationResult)
            {
                if (CountAB.countAB(guess, preGuess).Equals(providedHint))
                {
                    validGuesses.Add(guess);
                }
            }
            //from here  will try to remove all guesses(combinations) that contain any of the numbers in the previous guess that resuls in a 0A0B hint.
            holderGuesses = validGuesses;

            if (providedHint.Equals("0A0B"))
            {
                foreach(var guess in holderGuesses)
                {
                    if (guess.Contains(preGuess[0]) || guess.Contains(preGuess[1]) || guess.Contains(preGuess[2]) || guess.Contains(preGuess[3]))
                    {
                        validGuesses.Remove(guess);
                    }
                }
            }
            //to here

            newCombinationResult = validGuesses;

            if (newCombinationResult.Count > 0)
            {
                int digits = rand.Next(newCombinationResult.Count);
                joinRandoms = newCombinationResult[digits];
            }
            else
            {
                MessageBox.Show("Error, dont know why. Just restart game. Goodluck");
                // Handle the case when there are no valid guesses left
                // You can display an error message or take appropriate action
            }

            return joinRandoms;
        }

        public void addDisplayForm(string preGuess, string providedHint)
        {
            int number = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(number, preGuess, providedHint);
        }

        private void HintA_TextChanged(object sender, EventArgs e)
        {
            if (Hint.Text.Length >= 1)
            {
                string AGiven = Hint.Text;
                hintGiven = AGiven;
            }
        }

        public static void setPlayerName(string value)
        {
            playerName = value;
        }

        public static void setCodeNameTwo(string value)
        {
            mode = value;
        }

        private void compute_Click(object sender, EventArgs e)
        {
            breakerTimer.Start();
            if (string.IsNullOrWhiteSpace(Hint.Text))
            {
                errorInput.Text = "Fill the hints boxes, and try again";
            }
            else
            {
                errorInput.Text = "";
                previousGuess = computersGuess.Text;//assigns the displayed text(which is the former computer guess) to the previous text variable
                computersrandomGuess = breakerCalculation(previousGuess, Hint.Text);
                checkCount++;
                guessCount2.Text = $"Guess Count: {checkCount}"; //displays the current count
                allComputerGuessses += $"{computersrandomGuess} ";
                addDisplayForm(previousGuess, hintGiven);




                if (Hint.Text.Equals("4A0B"))
                {
                    breakerTimer.Stop();
                    gameScore = scoreClass.calculateScore(checkCount, secondstaken);
                    secretNumber = previousGuess; // Set the secret number to the previous guess

                    dataBase.databaseConnection(connectionString, playerName, mode, dateTime, checkCount, secondstaken, secretNumber, allComputerGuessses, gameScore);

                }
                else
                {
                    computersGuess.Text = computersrandomGuess; //displays the computer's guess
                }
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void breakerTimer_Tick(object sender, EventArgs e)
        {
            secondstaken++;
            TimeSpan timeTaken2 = TimeSpan.FromSeconds(secondstaken);
            timeholderDb2 = timeTaken2.ToString();
            timeSpent2.Text = $"Time Spent: {timeholderDb2}"; //display the seconds value after every second
        }


        private void CodeBreakerHomepage_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void computeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakerTimer.Start();
            if (string.IsNullOrWhiteSpace(Hint.Text))
            {
                errorInput.Text = "Fill the hints boxes, and try again";
            }
            else
            {
                errorInput.Text = "";
                previousGuess = computersGuess.Text;//assigns the displayed text(which is the former computer guess) to the previous text variable
                computersrandomGuess = breakerCalculation(previousGuess, Hint.Text);
                checkCount++;
                guessCount2.Text = $"Guess Count: {checkCount}"; //displays the current count
                allComputerGuessses += $"{computersrandomGuess} ";
                addDisplayForm(previousGuess, hintGiven);

                if (Hint.Text.Equals("4A0B"))
                {
                    breakerTimer.Stop();
                    gameScore = scoreClass.calculateScore(checkCount, secondstaken);
                    secretNumber = previousGuess; // Set the secret number to the previous guess

                    dataBase.databaseConnection(connectionString, playerName, mode, dateTime, checkCount, secondstaken, secretNumber, allComputerGuessses, gameScore);

                    // Display a message or perform any other action to indicate the game is solved
                }
                else
                {
                    computersGuess.Text = computersrandomGuess; //displays the computer's guess
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void computeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            breakerTimer.Start();
            if (string.IsNullOrWhiteSpace(Hint.Text))
            {
                errorInput.Text = "Fill the hints boxes, and try again";
            }
            else
            {
                errorInput.Text = "";
                previousGuess = computersGuess.Text;//assigns the displayed text(which is the former computer guess) to the previous text variable
                computersrandomGuess = breakerCalculation(previousGuess, Hint.Text);
                checkCount++;
                guessCount2.Text = $"Guess Count: {checkCount}"; //displays the current count
                allComputerGuessses += $"{computersrandomGuess} ";
                addDisplayForm(previousGuess, hintGiven);

                if (Hint.Text.Equals("4A0B"))
                {
                    breakerTimer.Stop();
                    gameScore = scoreClass.calculateScore(checkCount, secondstaken);
                    secretNumber = previousGuess; // Set the secret number to the previous guess

                    dataBase.databaseConnection(connectionString, playerName, mode, dateTime, checkCount, secondstaken, secretNumber, allComputerGuessses, gameScore);

                    // Display a message or perform any other action to indicate the game is solved
                }
                else
                {
                    computersGuess.Text = computersrandomGuess; //displays the computer's guess
                }
            }
        }
    }
}