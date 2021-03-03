using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Flag { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}
