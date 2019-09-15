using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BO
{
	public class ReservationBO
	{
		public int vehicle_number { get; set; }
		public DateTime reservation_date { get; set; }
		public int SlotCode { get; set; }
	}
}
