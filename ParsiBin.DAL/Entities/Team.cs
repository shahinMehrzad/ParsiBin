using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class Team : BaseEntity
    {        
        public string Name { get; set; }
        public string Logo { get; set; }
        //public Country Country { get; set; }
        //public City City { get; set; }
        //public Stadium Stadium { get; set; }
        public string Description { get; set; }
        public virtual List<SeasonTeams> SeasonTeams { get; set; }
        public virtual List<TeamPlayers> TeamPlayers { get; set; }
        //public virtual Coach Coach { get; set; }
    }
}
