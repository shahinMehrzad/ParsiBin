using ParsiBin.DTO.League;
using ParsiBin.DTO.Season;
using ParsiBin.DTO.Stadium;
using ParsiBin.DTO.Team;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.Match
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
