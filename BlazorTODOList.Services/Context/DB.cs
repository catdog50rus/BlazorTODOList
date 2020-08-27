using BlazorTODOList.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTODOList.Services.Context
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
