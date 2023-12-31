﻿using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.APP.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
