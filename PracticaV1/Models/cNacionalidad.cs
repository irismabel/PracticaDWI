using PracticaV1.Models;
using System.ComponentModel.DataAnnotations;

namespace PracticaV1.Models
{
	public class cNacionalidad
	{
		[Key]
		public int idNacionalidad { get; set; }
		public string pais {  get; set; }
		public string nacionalidad { get; set; }
	}
}

