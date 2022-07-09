
using FinalProject.Dtos;
using FinalProject.MasterDataModels;

namespace FinalProject.Services;

public interface ICountryService
{
    public Task<List<CountryDto>> GetAllAsync();
    public Task<CountryDto?> GetByIdAsync(int id);
    public Task CreateAsync(CountryDto country);
    public Task UpdateAsync(CountryDto country);
    public Task DeleteAsync(int id);
    Task<bool> Exists(int id);
}