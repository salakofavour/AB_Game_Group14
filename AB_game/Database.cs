using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3433
{
    internal class Database
    {
        public void databaseConnection(string connectionString, string player, string mode, string datetime, int count, int seconds, string secNumber, string JoinAllGuesses, float gameScore)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddAttempt";
            cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = player; // introPage.player;
            cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = mode; // introPage.mode;
            cmd.Parameters.Add("@param3", SqlDbType.VarChar).Value = datetime; // dateTime; //variable that grabs date and time from Form1 //this should be a string in datatype
            cmd.Parameters.Add("@param4", SqlDbType.Int).Value = count; // checkCount; //variable that increments each time check is hit
            cmd.Parameters.Add("@param5", SqlDbType.Int).Value = seconds;// timeHolderDb; // that starts when form1 begin is hit and continues until newgame; //change this to string not float in db and here
            cmd.Parameters.Add("@param6", SqlDbType.VarChar).Value = secNumber; // secretNumber; //this is a string, change the type
            cmd.Parameters.Add("@param7", SqlDbType.VarChar).Value = JoinAllGuesses; // allGuesses; //a string where each guess is appended after check, added at once to database when new game is hit
            cmd.Parameters.Add("@param8", SqlDbType.Float).Value = gameScore; //finalScore; //a variable that holds the total game score;//change to float

            conn.Open();
            int returnedValue = cmd.ExecuteNonQuery();
            if (returnedValue == 1)
            {
                MessageBox.Show("Added to Database");
            }
            else
            {
                MessageBox.Show("Not added to database");
            }
            conn.Close();
        }
/*        public float calculateScore(int count, int secondsCounted)
        {
            //the calculation is not really correct because there is some nuances in the instructions
            float gameScore = 10 * (10 - count + 1) - (secondsCounted / 10);
            return gameScore;
            //formula Game score = 10 x (10 - total tries + 1) - (total seconds taken / 10)

        }*/
    }
}
