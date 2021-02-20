using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoList.Data;
using TodoList.Shared;

namespace TodoList.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TodoController : ControllerBase
  {
    private readonly TodoListDbContext _context;
    private readonly IMapper _mapper;

    public TodoController(
      TodoListDbContext context,
      IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<List<Todo>> Get()
    {
      var todos = await _context.Todos.ToListAsync();
      return todos.Select(t => _mapper.Map<Shared.Todo>(t)).ToList();
    }
  }
}
