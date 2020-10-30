using Microsoft.EntityFrameworkCore;
using RkProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RkProj.Data
{
	public class ApplicationDbContext : DbContext
	{
		/// <summary>
		/// create properties to push to the database 
		/// </summary>
		/// <param name="options"></param>
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		/// <summary>
		/// to create the table. The table type and name match the model  
		/// </summary>
		public DbSet<Category> Category { get; set; }
	}
}
