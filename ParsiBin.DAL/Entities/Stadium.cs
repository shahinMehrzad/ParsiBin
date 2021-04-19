using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class Stadium : BaseEntity
    {
        public string Name { get; set; }
        public City City { get; set; }
        //public virtual List<Team> TeamsArena { get; set; }
    }
}
