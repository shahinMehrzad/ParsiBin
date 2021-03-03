using ParsiBin.DTO.City;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiBin.DTO.Country
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public List<CityDTO> Cities { get; set; }
    }
}
