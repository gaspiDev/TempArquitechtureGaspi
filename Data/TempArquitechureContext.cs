using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TempArquitechureContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public TempArquitechureContext(DbContextOptions<TempArquitechureContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }
    }
}
