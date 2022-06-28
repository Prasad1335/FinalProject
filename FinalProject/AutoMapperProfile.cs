using AutoMapper;
using FinalProject.Dtos;
using FinalProject.MasterDataModels;


public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Airline, AirlineDto>().ReverseMap();
        CreateMap<Airport, AirportDto>().ReverseMap();
        CreateMap<Amenities, AmenitiesDto>().ReverseMap();
        CreateMap<City, CityDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Customer, CustomerDto>().ReverseMap();
        CreateMap<Flight, FlightDto>().ReverseMap();
        CreateMap<FlightBooking, FlightBookingDto>().ReverseMap();
        CreateMap<FlightCustomerDetail, FlightCustomerDetailDto>().ReverseMap();
        CreateMap<FlightSchedule, FlightScheduleDto>().ReverseMap();
        CreateMap<Hotel, HotelDto>().ReverseMap();
        CreateMap<HotelAmenitiesLink, HotelAmenitiesLinkDto>().ReverseMap();
        CreateMap<HotelBooking, HotelBookingDto>().ReverseMap();
        CreateMap<HotelCustomerDetail, HotelCustomerDetailDto>().ReverseMap();
    }
}