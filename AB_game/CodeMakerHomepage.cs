using CIS3433;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace AB_game
{
    public partial class CodeMakerHomepage : Form
    {
        string generatedNum;
        string secretNumber = "";
        char characterInput1, characterInput2, characterInput3, characterInput4;
        string inputList;//will put all the 4 user's input in this string for easier handling -> check verifyInput()
        string dateTime = DateTime.Now.ToString(); //this works for datetime. if you want to seperate them, we can use the below one commented out 
        int checkCount = 0;
        string allGuesses;
        int secondsCount = 0;
        String timeHolderDb;
        string hint;


        const string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;";

        Welcome introPage = new Welcome();
        Class1 JoinandCount = new Class1();
        Database dataBase = new Database();
        Class2 score = new Class2();
        Random rand = new Random();

        float finalScoreCalcS;
        public static string playerName;
        public static string mode;


        public CodeMakerHomepage()
        {
            InitializeComponent();
            randomNumbers();
        }


        public void randomNumbers()//generates the random numbers
        {
            string secret = "";
            for (int i = 0; i < 4; i++)
            {
                generatedNum = rand.Next(0, 10).ToString();
                while (secret.Contains(generatedNum))
                {
                    generatedNum = rand.Next(0, 10).ToString();
                }
                secret += generatedNum.ToString(); //append all 4 generated random numbers as a string together.
            }
            secretNumber = secret;
            practice.Text = secretNumber; //will leave this for now just as proof of 4 unique random numbers
        }
        public void compareInput()// does most of the function in this page by referencing methods in class1
        {
            inputList = JoinandCount.joinInputs(characterInput1, characterInput2, characterInput3, characterInput4);

            hint = JoinandCount.countAB(secretNumber, inputList);

            Anumber.Text = hint;//placehokder to verify that the A value is counted properly, can remove later

        }

        public void displayInput(string randomGenerated)// display the randomly generated numbers in the textboxes and disable check button
        {
            input1.Text = randomGenerated[0].ToString();
            input2.Text = randomGenerated[1].ToString();
            input3.Text = randomGenerated[2].ToString();
            input4.Text = randomGenerated[3].ToString();
            checkInput.Enabled = false;
        }

        public static void setPlayerName(string value)
        {
            playerName = value;
        }
        public static void setCodeNameOne(string value)
        {
            mode = value;
        }
        public void checkFunction() //collates everything that will be done when check button is Clicked, so when the menustrip and context menu comes we just call these function for their check button
        {
            gameTimer.Start();
            if (string.IsNullOrWhiteSpace(input1.Text) || string.IsNullOrWhiteSpace(input2.Text) || string.IsNullOrWhiteSpace(input3.Text) || string.IsNullOrWhiteSpace(input4.Text))
            {
                incompleteInput.Text = "Fill all the boxes, and try again";
            }
            else
            {
                incompleteInput.Text = "";

                compareInput();
                checkCount++;// increment number of user tries after every click 
                guessCount.Text = $"Guess: {checkCount}"; //will display the new count on the form with the text in front of it.
                allGuesses += $"{inputList} -> {hint} "; //when check is clicked the current guess is added to the "allGuesses" string

                if (hint.Contains("4A0B"))//this only happens after there is 4,meaning the guess is correct end game. 
                {
                    gameTimer.Stop();

                    // playerName = introPage.player; //assign playername from welcome class to a variable here for easier use
                    // mode = introPage.mode; //assign mode from welcome class to a variable here for easier use
                    finalScoreCalcS = score.calculateScore(checkCount, secondsCount);

                    MessageBox.Show("The Right Values Have Been Guessed");
                    incompleteInput.Text = mode;

                    GameFinalScore.Text = finalScoreCalcS.ToString();
                    //the below is the database function from class2
                    dataBase.databaseConnection(connectionString, playerName, mode, dateTime, checkCount, secondsCount, secretNumber, allGuesses, finalScoreCalcS);
                    checkInput.Enabled = false;

                }
            }

        }
        public void restartFunction() // collates everything that will be done when check button is LinkClickedEventArgs into this, so when the menustrip and context menu comes we just call these function for their check button
        {
            this.Close();//closes the page 
        }
        public void addDisplayForm(string preGuess, string providedHint)
        {
            int number = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(number, preGuess, providedHint);
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            if (input1.Text.Length >= 1)
            {
                characterInput1 = char.Parse(input1.Text);
            }
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            if (input2.Text.Length >= 1)
            {
                characterInput2 = char.Parse(input2.Text);
            }
        }

        private void input3_TextChanged(object sender, EventArgs e)
        {
            if (input3.Text.Length >= 1)
            {
                characterInput3 = char.Parse(input3.Text);
            }
        }

        private void input4_TextChanged(object sender, EventArgs e)
        {
            if (input4.Text.Length >= 1)
            {
                characterInput4 = char.Parse(input4.Text);
            }
        }

        private void checkInput_Click(object sender, EventArgs e)//click check button
        {
            checkFunction();
            addDisplayForm(inputList, hint);

        }


        private void Restart_Click(object sender, EventArgs e)
        {
            restartFunction();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //the timer interval has been set to 1000 whic is 1000 millisecond which is 1 second
            secondsCount++;// that means timeCount increments by 1 after every second
            TimeSpan timeTaken = TimeSpan.FromSeconds(secondsCount);
            timeHolderDb = timeTaken.ToString();
            timeSpent.Text = $"Time Spent: {timeHolderDb}"; //display the second value after every second
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkFunction();
            addDisplayForm(inputList, hint);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartFunction();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            restartFunction();
        }

        private void checkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            checkFunction();
            addDisplayForm(inputList, hint);
        }
    }
}
