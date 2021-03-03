using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class MatchResult : BaseEntity
    {
        public virtual Match Match { get; set; }
        public int HomeGoal { get; set; }
        public int AwayGoal { get; set; }
    }
}
