using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
