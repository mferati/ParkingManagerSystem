using ParkingManagerSystem.BO;
using ParkingManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BLL
{
	public class ParkingSlotsBLL
	{
		private readonly ParkingSlotDAL _db;

		public ParkingSlotsBLL()
		{
			_db = new ParkingSlotDAL();
		}
		public bool Insert(ParkingSlotsBO slot)
		{
			return _db.Add(slot);
		}
		public IEnumerable<ParkingSlotsBO> GetAll()
		{
			return _db.GetAll();
		}
	}
}
