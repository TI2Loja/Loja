using System;
using System.Collections.Generic;
using System.Text;
using Loja.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Loja.Data
{
    public class ApplicationUser : IdentityUser
    {

        /// <summary>
        /// nome da pessoa q se regista, e posteriormente, autentica
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// avatar da pessoa q se regista, e posteriormente, autentica
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// registo da hora+data da criação do registo
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
    public class LojaDB : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Construtor da classe
        /// serve para ligar esta classe à BD
        /// </summary>
        /// <param name="options"></param>
        public LojaDB(DbContextOptions<LojaDB> options)
            : base(options) { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            // insert DB seed
            modelBuilder.Entity<Users>().HasData(
               new Users { id = 1, role = "admin", username = "Setraick", nome = "Pedro Vinha", email = "aluno20179@ipt.pt", address = "RUA DOIS" },
               new Users { id = 2, role = "admin", username = "Dead Pooh", nome = "Francisco Pereira", email = "aluno21369@ipt.pt", address = "RUA TRÊS" },
               new Users { id = 3, role = "user", username = "CPipas", nome = "Cristina Sousa", email = "hiqybunnoffu-2698@gmail.com", address = "RUA UM" },
               new Users { id = 4, role = "user", username = "mrbuffed", nome = "Sónia Rosa", email = "garguero@gmail.com", address = "RUA B" },
               new Users { id = 5, role = "user", username = "badrihanna", nome = "António Santos", email = "badrihanna@gmail.com", address = "R Parque Gondarim 24" },
               new Users { id = 6, role = "user", username = "shotscott", nome = "Gustavo Alves", email = "shotscott@gmail.com", address = "RUA QUATRO" },
               new Users { id = 7, role = "user", username = "sparkmarc", nome = "Rosa Vieira", email = "sparkmarc@gmail.com", address = "RUA PRINCIPAL" },
               new Users { id = 8, role = "user", username = "cleverbryna", nome = "Daniel Dias", email = "cleverbryna@gmail.com", address = "RUA A" },
               new Users { id = 9, role = "user", username = "boggybryna", nome = "Tânia Gomes", email = "boggybryna@gmail.com", address = "RUA SÃO LUIZ" },
               new Users { id = 10, role = "user", username = "elflikebryna", nome = "Andreia Correia", email = "elflikebryna@gmail.com", address = "RUA PIAUI" }
             );

            modelBuilder.Entity<Product>().HasData(
               new Product { id = 1, item = "Fones", stock = 20, description = "Tem Noise Canceling", price = 15},
               new Product { id = 10, item = "Fones", stock = 35, description = "Autonomia até 30 horas", price = 20},
               new Product { id = 3, item = "Fones", stock = 25, description = "Pequenos", price = 40},
               new Product { id = 2, item = "Fones", stock = 15, description = "Pretos", price = 50},
               new Product { id = 4, item = "Fones", stock = 28, description = "Grandes", price = 10},
               new Product { id = 5, item = "Fones", stock = 34, description = "Amarelos", price = 20},
               new Product { id = 8, item = "Fones", stock = 8, description = "Razer", price = 16.77},
               new Product { id = 9, item = "Fones", stock = 6, description = "JGL", price = 14.55},
               new Product { id = 6, item = "Fones", stock = 43, description = "Bass", price = 16},
               new Product { id = 7, item = "Fones", stock = 20, description = "Cor de rosa", price = 13.99}
            );
        }
        //adicionar as 'tabelas' à BD
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
