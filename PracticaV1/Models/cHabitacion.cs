using PracticaV1.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace PracticaV1.Models
{
	public class cHabitacion
	{
		[Key]
		public int idHabitacion {  get; set; }
		public string numero { get; set; }
		public string estado { get; set; }
		public decimal costo { get; set; }
		public string descripcion { get; set;}
		public int fkTipo { get; set; }

	
	}
}

