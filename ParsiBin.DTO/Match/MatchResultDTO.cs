using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.Match
{
    public class MatchResultDTO
    {
        public int Id { get; set; }
        public MatchDTO Match { get; set; }
        public int HomeGoal { get; set; }
        public int AwayGoal { get; set; }
    }
}
