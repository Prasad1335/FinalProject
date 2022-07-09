using AutoMapper;
using FinalProject.MasterDataModels;
using FinalProject.MasterDataModels.DataAccess;
using FinalProject.Repository;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repository;

public class CountryRepository : ICountryRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CountryRepository(
        ApplicationDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<T>> GetAllAsync<T>()
    {
        
        var countryQuery = _mapper
            .ProjectTo<T>(_context.Countries);

        return await countryQuery.ToListAsync();
    }

    public async Task<T?> GetByIdAsync<T>(int id)
    {
       

        var country = await _mapper
            .ProjectTo<T>(_context.Countries
                .Where(m => m.CountryId == id))
            .FirstOrDefaultAsync();

        return country;
    }

    public async Task CreateAsync(Country country)
    {
        _context.Add(country);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Country country)
    {
        _context.Update(country);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var Country = await _context.Countries.FindAsync(id);
        if (Country != null)
        {
            _context.Countries.Remove(Country);
        }

        await _context.SaveChangesAsync();
    }

    public async Task<bool> Exists(int CountryId)
    {
        return await _context.Countries.AnyAsync(e => e.CountryId == CountryId);
    }
}