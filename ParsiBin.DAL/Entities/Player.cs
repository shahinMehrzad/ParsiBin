using ParsiBin.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Country Nationality { get; set; }
        public DateTime? RetirementDate { get; set; }
    }
}
