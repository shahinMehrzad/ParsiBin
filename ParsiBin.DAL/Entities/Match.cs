using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class Match : BaseEntity
    {
        public League League { get; set; }
        public Season Season { get; set; }
        public Stadium Stadium { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int Week { get; set; }
        public DateTime MatchDate { get; set; }
        /// <summary>
        /// Match Played = 1,
        /// 
        /// </summary>
        public int MatchStatus { get; set; }
    }
}
