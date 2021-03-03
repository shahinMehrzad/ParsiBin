using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class League : BaseEntity
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public virtual List<Season> Seasons { get; set; }
    }
}
