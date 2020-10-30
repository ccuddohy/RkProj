using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RkProj.Models
{
	/// <summary>
	/// all of the properties of this class will be columns of the database. Category is the table name.
	/// </summary>
	public class Category
	{
		/// <summary>
		/// SQL Server column can specified as an identity. An identity column means you do not pass
		/// the value. It automatically increments and adds new values. 
		/// </summary>
		[Key]
		public int Id { get; set; }
		
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
	}
}
