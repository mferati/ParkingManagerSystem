using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BO
{
	public class FloorBO
	{
		public int Floor_Code { get; set; }
		public int Block_Code { get; set; }
		public int Number_of_slots { get; set; }
		public bool is_Floor_Full { get; set; }
		public bool is_Reserved { get; set; }

	}
}
