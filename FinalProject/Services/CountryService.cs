
using AutoMapper;
using FinalProject.Dtos;
using FinalProject.MasterDataModels;
using FinalProject.Repository;
namespace FinalProject.Services;

public class CountryService : ICountryService
{

    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;
 

    public CountryService(ICountryRepository countryRepository , IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }
    public async Task<List<CountryDto>> GetAllAsync()
    {
        return await _countryRepository.GetAllAsync<CountryDto>();
    }

    public async Task<CountryDto?> GetByIdAsync(int id)
    {
        return await _countryRepository.GetByIdAsync<CountryDto>(id);
    }

    public async Task CreateAsync(CountryDto country)
    {
         var c =_mapper.Map<Country>(country);
        await _countryRepository.CreateAsync(c);
    }

    public async Task UpdateAsync(CountryDto country)
    {
        var c = _mapper.Map<Country>(country);
        await _countryRepository.UpdateAsync(c);
    }

    public async Task DeleteAsync(int id)
    {
        await _countryRepository.DeleteAsync(id);
    }

    public async Task<bool> Exists(int id)
    {
        return await _countryRepository.Exists(id);
    }
}