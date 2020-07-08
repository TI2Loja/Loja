using System;
using System.Collections.Generic;
using System.Text;
using Loja.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Loja.Data
{
    public class LojaDB : IdentityDbContext
    {
        /// <summary>
        /// Construtor da classe
        /// serve para ligar esta classe à BD
        /// </summary>
        /// <param name="options"></param>
        public LojaDB(DbContextOptions<LojaDB> options) : base(options) { }


        //adicionar as 'tabelas' à BD
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Loja.Models.ShoppingCart> ShoppingCart { get; set; }

    }
}
