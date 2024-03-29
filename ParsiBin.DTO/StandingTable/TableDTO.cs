﻿using ParsiBin.DTO.League;
using ParsiBin.DTO.Match;
using ParsiBin.DTO.Season;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.StandingTable
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
