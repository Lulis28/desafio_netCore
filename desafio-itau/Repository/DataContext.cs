using desafio_itau.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        public DbSet<Segmento> Segmento { get; set; }
        public DbSet<Moeda> Moeda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Segmento>().HasData(
                new Segmento
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Varejo",
                    ValorTaxa = 3.5,
                    CriadoEm = DateTime.Now,
                    AtualizadoEm = DateTime.Now
                },
                new Segmento
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Personnalite",
                    ValorTaxa = 1.5,
                    CriadoEm = DateTime.Now,
                    AtualizadoEm = DateTime.Now


                },
                new Segmento
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Private",
                    ValorTaxa = 0.5,
                    CriadoEm = DateTime.Now,
                    AtualizadoEm = DateTime.Now


                }
            );
            modelBuilder.Entity<Moeda>().HasData(
                new Moeda
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Dólar Americano",
                    WebHook = "https://economia.awesomeapi.com.br/last/USD-BRL",
                    WebHookParameter = "USDBRL",
                    CriadoEm = DateTime.Now,
                    AtualizadoEm = DateTime.Now


                },
                new Moeda
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Euro",
                    WebHook = "https://economia.awesomeapi.com.br/last/EUR-BRL",
                    WebHookParameter = "EURBRL",
                    CriadoEm = DateTime.Now,
                    AtualizadoEm = DateTime.Now


                }
            );
        }
    }
}
