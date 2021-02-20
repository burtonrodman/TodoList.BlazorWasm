using AutoMapper;

namespace TodoList.Api {
  public class TodoListApiMappingProfile : Profile {
    public TodoListApiMappingProfile()
    {
     CreateMap<Shared.Todo, Data.Entities.Todo>().ReverseMap();
    }
  }
}