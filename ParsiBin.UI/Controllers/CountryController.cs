using Mapster;
using Microsoft.AspNetCore.Mvc;
using ParsiBin.DTO.Country;
using ParsiBin.DTO.StandingTable;
using ParsiBin.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParsiBin.UI.Controllers
{
    public class CountryController
    {
        private readonly ICountryService _countryService;
        
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;            
        }        
    }
}
