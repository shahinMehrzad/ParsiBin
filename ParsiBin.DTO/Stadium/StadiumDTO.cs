using ParsiBin.DTO.City;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.Stadium
{
    public class StadiumDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CityDTO City { get; set; }
    }
}
