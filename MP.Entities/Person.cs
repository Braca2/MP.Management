using System;

namespace MP.Entities
{
	public class Person
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Comments { get; set; }
		public bool IsClient { get; set; }
	}
}
