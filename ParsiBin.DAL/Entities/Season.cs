using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class Season : BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public League League { get; set; }
        public List<SeasonTeams> SeasonTeams { get; set; }
    }
}
