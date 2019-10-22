using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace CodeFirstDemo
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
