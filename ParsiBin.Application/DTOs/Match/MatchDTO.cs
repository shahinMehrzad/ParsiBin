using ParsiBin.Application.DTOs.League;
using ParsiBin.Application.DTOs.Season;
using ParsiBin.Application.DTOs.Stadium;
using ParsiBin.Application.DTOs.Team;

namespace ParsiBin.Application.DTOs.Match
{
    public class MatchDTO
    {
        public int Id { get; set; }
        public LeagueDTO League { get; set; }
        public SeasonDTO Season { get; set; }
        public StadiumDTO Stadium { get; set; }
        public TeamDTO HomeTeam { get; set; }
        public TeamDTO AwayTeam { get; set; }
        public MatchResultDTO MatchResult { get; set; }
        public int Week { get; set; }
        public DateTime MatchDate { get; set; }
        public int MatchStatus { get; set; }
        public string MatchStaus_string
        {
            get
            {
                switch (MatchStatus)
                {
                    case 0:
                        if ((MatchDate - DateTime.Now).TotalMinutes > 90)
                            return "...";
                        else
                            return "Match start soon.";
                    case 1:
                        return "Done.";
                    case 2:
                        return "Postpone";
                }
                return "";
            }
        }
    }
}
