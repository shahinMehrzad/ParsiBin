using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.Match
{
    public class AddMatchResultDTO
    {
        public int League { get; set; }
        public int Season { get; set; }
        public int Match { get; set; }
        public int HomeGoal { get; set; }
        public int AwayGoal { get; set; }
    }
}
