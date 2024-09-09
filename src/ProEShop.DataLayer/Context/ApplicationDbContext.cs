
using Microsoft.EntityFrameworkCore;
using ProEShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEShop.DataLayer.Context;
    public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { 
    }

    public DbSet<Category> Categories{ get; set; }
}
