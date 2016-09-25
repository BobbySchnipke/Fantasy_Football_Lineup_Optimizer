using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fantasy_Football_Value
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void hybridFinalTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hybridFinalTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fantasy_FootballDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fantasy_FootballDataSet.HybridFinalTable' table. You can move, or remove it, as needed.
            this.hybridFinalTableTableAdapter.Fill(this.fantasy_FootballDataSet.HybridFinalTable);

        }

        private void NumPlayersLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumPlayersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FanDuelNumPositionsButton_Click(object sender, EventArgs e)
        {
            // Reset all values for number of players to Fanduel Defaults
            QbNumericUpDown.Value = 1;
            RbNumericUpDown.Value = 2;
            WrNumericUpDown.Value = 3;
            TeNumericUpDown.Value = 1;
            KNumericUpDown.Value = 1;
            DStNumericUpDown.Value = 1;
        }

        private void OptimizeButton_Click(object sender, EventArgs e)
        {

        }

            public class Player
        {
            public string Position { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Salary { get; set; }
            public string Team { get; set; }
            public double Upper { get; set; }
            public double Lower { get; set; }
            public double Risk { get; set; }
            public double Points { get; set; }
            public double DollarsPerPoint { get; set; }
            public string InjuryIndicator { get; set; }

            private static void OpenSqlConnection(string CS)
            {
                List<Player> Players = new List<Player>();

                using (SqlConnection connection = new SqlConnection(CS))
                {
                    connection.Open();
                    SqlCommand SqlCommand = new SqlCommand("SELECT * FROM HybridFinalTable", connection);
                    SqlDataReader reader = SqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Player p = new Player();
                        p.Position = (string) reader["Position"];
                        p.FirstName = (string) reader["FirstName"];
                        p.LastName = (string) reader["LastName"];
                        p.Salary = (int) reader["Salary"];
                        p.Team = (string) reader["Team"];
                        p.Upper = (double) reader["Upper"];
                        p.Lower = (double)reader["Lower"];
                        p.Points = (double)reader["Points"];
                        p.DollarsPerPoint = (double)reader["$/Point"];
                        p.InjuryIndicator = (string)reader["InjuryIndicator"];
                        Players.Add(p);
                    }

                }

            }
        }
    }
}
