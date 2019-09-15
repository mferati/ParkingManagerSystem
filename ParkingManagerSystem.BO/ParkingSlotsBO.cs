using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BO
{
	public class ParkingSlotsBO
	{
		public int FloorCode { get; set; }
		public int SlotCode { get; set; }
		public bool is_reserved { get; set; }
	}
}
