using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.Match
{
    public class AddNewMatchDTO
    {
        public int League { get; set; }
        public int Season { get; set; }
        public int Stadium { get; set; }
        public int HomeTeam { get; set; }
        public int AwayTeam { get; set; }
        public int Week { get; set; }
        public DateTime MatchDate { get; set; }
        public int MatchStatus { get; set; }
    }
}
