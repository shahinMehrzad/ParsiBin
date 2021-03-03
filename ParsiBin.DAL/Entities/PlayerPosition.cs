using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DAL.Entities
{
    public class PlayerPosition
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public Position Position { get; set; }
    }
}
