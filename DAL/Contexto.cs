using System;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Pruebas.Entidades;

namespace Pruebas.DAL
{
public class Contexto:DbContext
{
   public DbSet<Actores> Actores { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
       optionsBuilder.UseSqlite(@"Data Source= DATA\Clase2.db");
   }

}
}
