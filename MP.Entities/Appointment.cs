using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Entities
{
	public class Appointment
	{
		public Guid ID { get; set; }
		public DateTime Date { get; set; }
		public Person Client { get; set; }
		public Person Employee { get; set; }
		public Service Service { get; set; }
	}
}
