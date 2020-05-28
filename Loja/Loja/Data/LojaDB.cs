using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;

namespace Loja.Data
{
    public class LojaDB : DbContext
    {
        /// <summary>
        /// Construtor da classe
        /// serve para ligar esta classe à BD
        /// </summary>
        /// <param name="options"></param>
        public LojaDB(DbContextOptions<LojaDB> options) : base(options) { }


        // adicionar as 'tabelas' à BD
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Pament { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Users> User { get; set; }

    }
}
