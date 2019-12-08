using DigitalCar.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.RepositorioEF
{
    public class BD : DbContext
    {
        public DbSet<Funcionario> funcionario { get; set; }
        public BD() : base("DigitalCar")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Funcionario>().Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Funcionario>().Property(x => x.Cpf).IsRequired().HasColumnType("varchar").HasMaxLength(14);
            modelBuilder.Entity<Funcionario>().Property(x => x.Rg).IsRequired().HasColumnType("varchar").HasMaxLength(12);
            modelBuilder.Entity<Funcionario>().Property(x => x.DataNascimento).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Funcionario>().Property(x => x.Email).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Funcionario>().Property(x => x.Telefone).IsRequired().HasColumnType("varchar").HasMaxLength(17);
            modelBuilder.Entity<Funcionario>().Property(x => x.Celular).IsRequired().HasColumnType("varchar").HasMaxLength(15);
            modelBuilder.Entity<Funcionario>().Property(x => x.Rua).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Funcionario>().Property(x => x.Turno).IsRequired().HasColumnType("varchar").HasMaxLength(5);
            modelBuilder.Entity<Funcionario>().Property(x => x.Funcao).IsRequired().HasColumnType("varchar").HasMaxLength(15);
            modelBuilder.Entity<Funcionario>().Property(x => x.Status).IsRequired().HasColumnType("varchar").HasMaxLength(7);
            modelBuilder.Entity<Funcionario>().Property(x => x.Numero).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Funcionario>().Property(x => x.Bairro).IsRequired().HasColumnType("varchar").HasMaxLength(30);
            modelBuilder.Entity<Funcionario>().Property(x => x.Cidade).IsRequired().HasColumnType("varchar").HasMaxLength(30);
            modelBuilder.Entity<Funcionario>().Property(x => x.Cep).IsRequired().HasColumnType("varchar").HasMaxLength(9);
            modelBuilder.Entity<Funcionario>().Property(x => x.UF).IsRequired().HasColumnType("varchar").HasMaxLength(2);


        }

    }
}
