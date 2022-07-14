using ParsiBin.Application.DTOs.Stadium;

namespace ParsiBin.Application.DTOs.Team
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public StadiumDTO Stadium { get; set; }
    }
}
