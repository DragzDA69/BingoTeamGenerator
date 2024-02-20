using BingoTeamGenerator.Classes;
using BingoTeamGenerator.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BingoTeamGenerator
{
    public partial class Form1 : Form
    {
        public int NumberOfTeams { get; set; }
        public List<PlayerInfo> PlayersList { get; set; }
        //public List<Team> SortedTeams { get; set; }
        public TeamBalancer Balancer { get; set; }

        public Form1()
        {
            InitializeComponent();
            NumberOfTeams = 2;
            PlayersList = new List<PlayerInfo>();
        }

        private void LoadFileButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog fDialog = new OpenFileDialog
                {
                    Title = "Load Player List",
                    Filter = "Text files (*.txt)|*.txt",
                    InitialDirectory = "C:\\Users\\Zach\\Desktop\\Team Generator",  // TODO : Remove this and default to C:\
                    //fDialog.InitialDirectory = @"C:\";    // TODO : Uncomment
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                if (fDialog.ShowDialog() == DialogResult.OK)
                {
                    var usersRaw = File.ReadAllText(fDialog.FileName).Split(';');
                    foreach (var user in usersRaw)
                    {
                        if (!string.IsNullOrWhiteSpace(user))
                        {
                            var userSplit = user.Replace("\r\n", string.Empty).Split(',');
                            PlayersList.Add(new PlayerInfo(userSplit[0], userSplit[1]));
                        }
                    }

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Username", typeof(string));
                    dt.Columns.Add("Tier", typeof(int));

                    PlayersList.ForEach(x => dt.Rows.Add(x.Username, x.Tier));

                    PlayersListGrid.DataSource = dt;
                    LoadedPlayersTotalLabel.Text = "Total: " + PlayersList.Count.ToString();

                    MessageBox.Show("Player list successfully loaded!");
                }
                else
                {
                    MessageBox.Show("No file selected!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void GenerateTeamsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayersList.Count < 2)
                {
                    MessageBox.Show("Not enough players to sort.", "Not enough players");
                    return;
                }
                if (!int.TryParse(NumTeamsTextbox.Text, out int numTeams))
                {
                    MessageBox.Show("Please enter a number");
                }
                if (NumberOfTeams > PlayersList.Count)
                {
                    MessageBox.Show("You can not have more teams then players", "To Many Teams");
                    return;
                }

                var balancer = new TeamBalancer();
                var balancedTeams = balancer.BalanceGroups(PlayersList, NumberOfTeams);

                GeneratedPlayersLabel.Text = "Total2: " + balancedTeams.Count.ToString();

                DataTable dt = new DataTable();
                dt.Columns.Add("Username", typeof(string));
                dt.Columns.Add("Tier", typeof(int));

                balancedTeams.ForEach(team =>
                {
                    if (team.TeamNumber > 1)
                        dt.Rows.Add(string.Empty, 0);
                    dt.Rows.Add("Team: " + team.TeamNumber, 0);
                    team.Members.ForEach(member =>
                    {
                        dt.Rows.Add(member.Username, member.Tier);
                    });
                });

                TeamsDataGrid.DataSource = dt;
                LoadedPlayersTotalLabel.Text = "Total: " + PlayersList.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumTeamsTextbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(NumTeamsTextbox.Text, out int numOfTeams))
            {
                NumberOfTeams = numOfTeams;
            }
        }
    }
}
