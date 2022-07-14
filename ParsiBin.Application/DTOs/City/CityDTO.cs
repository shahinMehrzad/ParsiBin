using ParsiBin.Application.DTOs.Country;
using ParsiBin.DTO.Stadium;

namespace ParsiBin.Application.DTOs.City
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CountryDTO Country { get; set; }
        public List<StadiumDTO> Stadiums { get; set; }
    }
}
