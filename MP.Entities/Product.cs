﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Entities
{
	public class Product
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Comments { get; set; }
		public string Price { get; set; }
	}
}
