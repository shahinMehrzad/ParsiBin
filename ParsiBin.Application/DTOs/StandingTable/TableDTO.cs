using ParsiBin.Application.DTOs.League;
using ParsiBin.Application.DTOs.Match;
using ParsiBin.Application.DTOs.Season;

namespace ParsiBin.Application.DTOs.StandingTable
{
    public class TableDTO
    {
        public TableDTO()
        {
            League = new LeagueDTO();
            Season = new SeasonDTO();
            Last5Match = new List<MatchResultDTO>();
        }
        public LeagueDTO League { get; set; }
        public SeasonDTO Season { get; set; }
        public string Logo { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int MatchPlayed { get; set; }
        public int MatchWon { get; set; }
        public int MatchDrawn { get; set; }
        public int MatchLost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int Goaldiffrence { get { return GoalsFor - GoalsAgainst; } }
        public int Points { get { return (MatchWon * 3) + MatchDrawn; } }
        public List<MatchResultDTO> Last5Match { get; set; }
        public int Rank { get; set; }
    }
}
