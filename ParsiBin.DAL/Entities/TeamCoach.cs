using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class TeamCoach
    {
        public int Id { get; set; }
        public Team Team { get; set; }
        public Coach Coach { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? LeftDate { get; set; }
        public bool Status { get; set; }
    }
}
