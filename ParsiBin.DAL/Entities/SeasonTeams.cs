using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class SeasonTeams
    {
        public int Id { get; set; }
        public Season Season { get; set; }
        public Team Team { get; set; }
    }
}
