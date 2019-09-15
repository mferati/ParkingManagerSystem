using ParkingManagerSystem.BO;
using ParkingManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BLL
{
	public class FloorBLL
	{
		private readonly FloorDAL _db;

		public FloorBLL()
		{
			_db = new FloorDAL();
		}

		public bool Insert(FloorBO floor)
		{
			return _db.Add(floor);
		}

		public IEnumerable<FloorBO> GetAll()
		{
			return _db.GetAll();
		}
	}
}
