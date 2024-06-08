using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PracticaV1.Models;

namespace PracticaV1.Context;

public partial class HotelimlcContext : DbContext
{
	public HotelimlcContext() { }

	public HotelimlcContext(DbContextOptions<HotelimlcContext> options) : base(options) 
	{
	
	}
	public DbSet<cHabitacion> tHabitacion { get; set; }
	public DbSet<cRegistrador> tRegistrador { get; set;}
    public DbSet<cAlquiler> tAlquiler { get; set; }
    public DbSet<cCliente> tCliente { get; set; }
    public DbSet<cEstado> tEstado { get; set; }
    public DbSet<cNacionalidad> tNacionalidad { get; set; }

    public DbSet<cTipoHabitacions> tTipoHabitacion{ get; set; }

   
}
