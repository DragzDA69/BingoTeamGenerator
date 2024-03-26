
namespace BingoTeamGenerator.Classes
{
    public class PlayerInfo
    {
        public PlayerInfo() { }
        public PlayerInfo(string username, string discord, string tier)
        {
            Username = username;
            Discord = discord;
            Tier = int.Parse(tier);
        }
        public PlayerInfo(string username, string discord, int tier)
        {
            Username = username;
            Discord = discord;
            Tier = tier;
        }


        public string Username { get; set; }
        public string Discord { get; set; }
        public int Tier { get; set; }
    }
}
