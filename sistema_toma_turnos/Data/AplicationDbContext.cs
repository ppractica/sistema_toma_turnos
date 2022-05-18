using Microsoft.EntityFrameworkCore;
using sistema_toma_turnos.Models; //LIBRERIA PARA HACER REFERENCIA A LAS CLASES DEL MODELS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace sistema_toma_turnos.Data 
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
        : base(options)
        {
        } 

        public DbSet<Clientes> Clientes { get; set; }
    
  
    
    }
}
