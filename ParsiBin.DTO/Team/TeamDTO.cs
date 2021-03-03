using ParsiBin.DTO.Stadium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.Team
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public StadiumDTO Stadium { get; set; }
    }
}
