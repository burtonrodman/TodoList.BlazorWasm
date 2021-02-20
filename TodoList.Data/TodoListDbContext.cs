using System;
using Microsoft.EntityFrameworkCore;
using TodoList.Data.Entities;

namespace TodoList.Data
{
  public class TodoListDbContext : DbContext
  {
    public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options) { }
    public DbSet<Todo> Todos { get; set; }
  }
}
