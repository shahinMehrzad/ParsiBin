using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class TeamPlayers
    {
        public int Id { get; set; }
        public Team Team { get; set; }
        public Player Player { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? LeftDate { get; set; }
        public int? ShirtNumber { get; set; }
        public bool Status { get; set; }
    }
}
