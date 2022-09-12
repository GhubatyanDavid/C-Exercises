using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Automarket.DAL
{
    internal class ApplicationDbCOntext:DbContext
    {
        public ApplicationDbCOntext(DbContextOptions<ApplicationDbCOntext> options):base(options)
        {

        }
        public DbSet<Car> car { get; set; }
    }
}
