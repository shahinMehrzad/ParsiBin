using ParsiBin.Application.DTOs.City;

namespace ParsiBin.Application.DTOs.Country
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }
        public List<CityDTO> Cities { get; set; }
    }
}
