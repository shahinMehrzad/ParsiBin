using ParsiBin.Application.DTOs.Country;

namespace ParsiBin.Application.Interfaces.Services
{
    public interface ICountryServices
    {
        Task<IEnumerable<CountryDTO>> GetList();
    }
}
