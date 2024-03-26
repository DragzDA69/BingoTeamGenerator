using BingoTeamGenerator.Classes;
using BingoTeamGenerator.Utilities;
using Microsoft.VisualBasic.FileIO;
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

        public Form1()
        {
            InitializeComponent();
            NumberOfTeams = 2;
            PlayersList = new List<PlayerInfo>();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            TeamsDataGrid.DataSource = null;
            NumberOfTeams = 2;
            NumTeamsTextbox.Text = "2";
            TotalGeneratedTeamsLabel.Text = "Total: 0";
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fDialog = new OpenFileDialog
                {
                    Title = "Load Player List",
                    Filter = "CSV (*.csv)|*.csv",
                    InitialDirectory =
                #if DEBUG
                    "C:\\Users\\Zach\\Desktop\\Team Generator",
                #else
                    "C:\\",
                #endif
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                if (fDialog.ShowDialog() == DialogResult.OK)
                {
                    PlayersList.Clear();
                    TeamsDataGrid.DataSource = null;

                    using (TextFieldParser tfp = new TextFieldParser(fDialog.FileName))
                    {
                        tfp.TextFieldType = FieldType.Delimited;
                        tfp.SetDelimiters(",");
                        while (!tfp.EndOfData)
                        {
                            var data = tfp.ReadFields();
                            if (data[2].ToLower() != "tier") 
                                PlayersList.Add(new PlayerInfo(data[0], data[1], data[2]));
                        }
                    }

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Username", typeof(string));
                    dt.Columns.Add("Discord", typeof(string));
                    dt.Columns.Add("Tier", typeof(string));

                    PlayersList.ForEach(x => dt.Rows.Add(x.Username, x.Discord, x.Tier));

                    PlayersDataGrid.DataSource = dt;
                    TotalLoadedPlayersLabel.Text = "Total: " + PlayersList.Count.ToString();

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
                if (NumberOfTeams < 2)
                {
                    MessageBox.Show("You must have at least 2 teams", "Not Enough Teams");
                    return;
                }
                if (NumberOfTeams > PlayersList.Count)
                {
                    MessageBox.Show("You can not have more teams then players", "To Many Teams");
                    return;
                }

                var balancedTeams = TeamBalancer.BalanceGroups(PlayersList, NumberOfTeams);

                DataTable dt = new DataTable();
                dt.Columns.Add("Username", typeof(string));
                dt.Columns.Add("Discord", typeof(string));
                dt.Columns.Add("Tier", typeof(string));

                balancedTeams.ForEach(team =>
                {
                    if (team.TeamNumber > 1)
                        dt.Rows.Add(string.Empty, "", "");
                    dt.Rows.Add("Team: " + team.TeamNumber, "", "");
                    team.Members.ForEach(member =>
                    {
                        dt.Rows.Add(member.Username, member.Tier);
                    });
                });

                TeamsDataGrid.DataSource = dt;
                TotalGeneratedTeamsLabel.Text = "Total: " + balancedTeams.Count.ToString();
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
