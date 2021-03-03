using ParsiBin.DAL.Entities;
using ParsiBin.DTO.Country;
using ParsiBin.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParsiBin.Services.Contracts
{
    public interface ICountryService 
    {
        Task<IEnumerable<CountryDTO>> GetList();
    }
}
