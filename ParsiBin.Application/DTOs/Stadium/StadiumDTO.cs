using ParsiBin.Application.DTOs.City;

namespace ParsiBin.Application.DTOs.Stadium
{
    public class StadiumDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CityDTO City { get; set; }
    }
}
