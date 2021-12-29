using System;
using System.Collections.Generic;
using System.Linq; // o linq funções do linq são convertidas em consultas sql no banco de dados
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext //o DbContext encapsula uma sessão com o banco de dados
                                                //para um determinado modelo de dados(representado por Dbsets)
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        //Dbset representa a coleção de entidades de uma dado tipo em um contexto.Tipicamente corresponde
        //a uma tabela do banco de dados
        public DbSet<Department> Department { get; set; } 
        public DbSet<Seller> Seller{ get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
