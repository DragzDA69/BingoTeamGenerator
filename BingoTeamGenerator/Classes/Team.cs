
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

        public (bool, string) AddNewMember(PlayerInfo info)
        {
            try
            {
                Members.Add(info);
                return (true, "Ok");
            }
            catch (System.Exception e)
            {
                return (false, e.Message);
            }
        }

        public (bool, string) AddNewMember(string username, int tier)
        {
            try
            {
                Members.Add(new PlayerInfo(username, tier));
                return (true, "Ok");
            }
            catch (System.Exception e)
            {
                return (false, e.Message);
            }
        }
    }
}
