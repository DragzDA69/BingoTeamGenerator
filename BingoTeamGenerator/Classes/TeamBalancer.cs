using BingoTeamGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoTeamGenerator.Utilities
{
    public class TeamBalancer
    {
        private Random random = new Random(); // Initialize Random object

        public List<Team> BalanceGroups(List<PlayerInfo> users, int totalGroups)
        {
            // Shuffle users
            var shuffledUsers = users.OrderBy(x => random.Next()).ToList();

            // Sort users by tier
            var sortedUsers = shuffledUsers.OrderBy(u => u.Tier).ToList();

            // Initialize teams with team numbers
            var teams = Enumerable.Range(1, totalGroups)
                                  .Select(i => new Team(i))
                                  .ToList();

            // Calculate the ideal number of members per team
            int idealCountPerTeam = (int)Math.Ceiling((double)sortedUsers.Count / totalGroups);

            // Distribute users evenly
            int currentIndex = 0;
            foreach (var user in sortedUsers)
            {
                teams[currentIndex].Members.Add(user);
                currentIndex = (currentIndex + 1) % totalGroups;
            }

            // Rebalance each team to ensure equal or close-to-equal number of each tier
            RebalanceTeams(teams, idealCountPerTeam);

            return teams;
        }

        private void RebalanceTeams(List<Team> teams, int idealCountPerTeam)
        {
            // Iterate through each team
            foreach (var team in teams)
            {
                // Group users by tier
                var groupedUsersByTier = team.Members.GroupBy(u => u.Tier).ToList();

                // Calculate the target number of users for each tier
                int targetCountPerTier = idealCountPerTeam / groupedUsersByTier.Count;

                // Iterate through each tier
                foreach (var tierGroup in groupedUsersByTier)
                {
                    int tier = tierGroup.Key;
                    int currentCount = tierGroup.Count();

                    // If the current count is less than the target count, add users from other teams
                    while (currentCount < targetCountPerTier)
                    {
                        // Find a team with excess users of this tier
                        var sourceTeam = teams.FirstOrDefault(t => t != team && t.Members.Count(u => u.Tier == tier) > targetCountPerTier);

                        // If such a team is found, transfer a user from it to the current team
                        if (sourceTeam != null)
                        {
                            var userToTransfer = sourceTeam.Members.FirstOrDefault(u => u.Tier == tier);
                            if (userToTransfer != null)
                            {
                                team.Members.Add(userToTransfer);
                                sourceTeam.Members.Remove(userToTransfer);
                                currentCount++;
                            }
                            else
                            {
                                // If there are no more users of this tier in the source team, exit the loop
                                break;
                            }
                        }
                        else
                        {
                            // If no team with excess users of this tier is found, exit the loop
                            break;
                        }
                    }
                }
            }
        }
    }

}
