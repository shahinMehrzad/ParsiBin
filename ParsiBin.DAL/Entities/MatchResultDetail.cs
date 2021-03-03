using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class MatchResultDetail
    {
        public int Id { get; set; }
        public MatchResult MatchResult { get; set; }
        public int Minute { get; set; }
        public Player Player { get; set; }
        public Team Team { get; set; }
        public ActionType ActionType { get; set; }
    }
}
