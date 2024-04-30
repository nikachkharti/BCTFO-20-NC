using AutoMapper;
using Todo.Entities;
using Todo.Models;

namespace Todo.Service
{
    public static class MappingInitializer
    {
        public static IMapper Initialize()
        {
            MapperConfiguration configuration = new(config =>
            {
                config.CreateMap<TodoEntity, TodoForCreatingDto>();
                config.CreateMap<TodoEntity, TodoForUpdatingDto>();
                config.CreateMap<TodoEntity, TodoForGettingDto>();
            });

            return configuration.CreateMapper();
        }
    }
}
