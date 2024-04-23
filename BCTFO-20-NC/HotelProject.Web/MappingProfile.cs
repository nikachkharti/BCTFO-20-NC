using AutoMapper;
using HotelProject.Models;
using HotelProject.Models.DTOS;

namespace HotelProject.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GuestReservation, GuestReservationDto>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
                .ForMember(dest => dest.GuestId, options => options.MapFrom(src => src.GuestId))
                .ForMember(dest => dest.FirstName, options => options.MapFrom(src => src.Guest.FirstName))
                .ForMember(dest => dest.LastName, options => options.MapFrom(src => src.Guest.LastName))
                .ForMember(dest => dest.PersonalNumber, options => options.MapFrom(src => src.Guest.PersonalNumber))
                .ForMember(dest => dest.PhoneNumber, options => options.MapFrom(src => src.Guest.PhoneNumber))
                .ForMember(dest => dest.ReservationId, options => options.MapFrom(src => src.ReservationId))
                .ForMember(dest => dest.CheckInDate, options => options.MapFrom(src => src.Reservation.CheckInDate))
                .ForMember(dest => dest.CheckOutDate, options => options.MapFrom(src => src.Reservation.CheckOutDate))
                .ReverseMap();

            CreateMap<GuestWithReservationForUpdatingDto, Guest>()
                .ForMember(dest => dest.Id, options => options.MapFrom(source => source.GuestId))
                .ReverseMap();

            CreateMap<GuestWithReservationForUpdatingDto, Reservation>()
                .ForMember(dest => dest.Id, options => options.MapFrom(source => source.ReservationId))
                .ReverseMap();

            CreateMap<GuestReservation, GuestWithReservationForUpdatingDto>()
                .ForMember(dest => dest.FirstName, options => options.MapFrom(src => src.Guest.FirstName))
                .ForMember(dest => dest.LastName, options => options.MapFrom(src => src.Guest.LastName))
                .ForMember(dest => dest.PersonalNumber, options => options.MapFrom(src => src.Guest.PersonalNumber))
                .ForMember(dest => dest.PhoneNumber, options => options.MapFrom(src => src.Guest.PhoneNumber))
                .ForMember(dest => dest.CheckInDate, options => options.MapFrom(src => src.Reservation.CheckInDate))
                .ForMember(dest => dest.CheckOutDate, options => options.MapFrom(src => src.Reservation.CheckOutDate))
                .ReverseMap();

            CreateMap<GuestReservationForCreatingDto, GuestReservation>().ReverseMap();
            CreateMap<GuestReservationForCreatingDto, Guest>().ReverseMap();
            CreateMap<GuestReservationForCreatingDto, Reservation>().ReverseMap();

            CreateMap<UserRegistrationDto, ApplicationUser>()
                .ForMember(dest => dest.UserName, options => options.MapFrom(src => src.Email))
                .ReverseMap();
        }
    }
}
