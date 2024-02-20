
namespace BingoTeamGenerator.Classes
{
    public class PlayerInfo
    {
        public PlayerInfo() { }
        public PlayerInfo(string username, string tier)
        {
            Username = username;
            Tier = int.Parse(tier);
        }
        public PlayerInfo(string username, int tier)
        {
            Username = username;
            Tier = tier;
        }


        public string Username { get; set; }
        public int Tier { get; set; }
    }
}
