using ParsiBin.DTO.Country;
using ParsiBin.DTO.Stadium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.City
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CountryDTO Country { get; set; }
        public List<StadiumDTO> Stadiums { get; set; }
    }
}
