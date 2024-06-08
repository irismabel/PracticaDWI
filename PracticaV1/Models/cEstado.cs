using PracticaV1.Models;
using System.ComponentModel.DataAnnotations;

namespace PracticaV1.Models
{
	public class cEstado
	{
		[Key]
		public int idEstado { get; set; }
		public string nombre { get; set; }
	}
}

