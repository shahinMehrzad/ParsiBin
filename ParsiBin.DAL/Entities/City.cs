using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public virtual List<Stadium> Stadiums { get; set; }
    }
}
