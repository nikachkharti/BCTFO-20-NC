using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Todo.Entities;
using Todo.Models;
using Todo.Models.Identity;

namespace Todo.Service
{
    public static class MappingInitializer
    {
        public static IMapper Initialize()
        {
            MapperConfiguration configuration = new(config =>
            {
                config.CreateMap<TodoEntity, TodoForCreatingDto>().ReverseMap();
                config.CreateMap<TodoEntity, TodoForUpdatingDto>().ReverseMap();
                config.CreateMap<TodoEntity, TodoForGettingDto>().ReverseMap();

                config.CreateMap<UserDto, IdentityUser>().ReverseMap();
                config.CreateMap<RegistrationRequestDto, IdentityUser>()
                .ForMember(destination => destination.UserName, options => options.MapFrom(source => source.Email))
                .ForMember(destination => destination.NormalizedUserName, options => options.MapFrom(source => source.Email.ToUpper()))
                .ForMember(destination => destination.Email, options => options.MapFrom(source => source.Email))
                .ForMember(destination => destination.NormalizedEmail, options => options.MapFrom(source => source.Email.ToUpper()))
                .ForMember(destination => destination.PhoneNumber, options => options.MapFrom(source => source.PhoneNumber));

            });

            return configuration.CreateMapper();
        }
    }
}
