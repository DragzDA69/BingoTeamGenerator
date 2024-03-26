
using System;
using System.Collections.Generic;

namespace BingoTeamGenerator.Classes
{
    public class Team
    {
        public List<PlayerInfo> Members { get; set; }
        public int TeamNumber { get; set; }

        public Team(int teamNumber)
        {
            Members = new List<PlayerInfo>();
            TeamNumber = teamNumber;
        }

        public string ConvertToCsv()
        {
            var csv = $"Team {TeamNumber},,";
            Members.ForEach(p => csv += Environment.NewLine + p.ConvertToCsv());
            csv += Environment.NewLine + ",,";
            return csv;
        }

        public (bool, string) AddNewMember(PlayerInfo info)
        {
            try
            {
                Members.Add(info);
                return (true, "Ok");
            }
            catch (Exception e)
            {
                return (false, e.Message);
            }
        }

        public (bool, string) AddNewMember(string username, string discord, int tier)
        {
            try
            {
                Members.Add(new PlayerInfo(username, discord, tier));
                return (true, "Ok");
            }
            catch (Exception e)
            {
                return (false, e.Message);
            }
        }
    }
}
