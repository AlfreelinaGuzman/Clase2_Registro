using System;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace Pruebas.Entidades{
public class Actores{
    [Key]
    public int ActorID { get; set; }
    public string Nombres { get; set; }
    public decimal Salario { get; set; }
}

}

