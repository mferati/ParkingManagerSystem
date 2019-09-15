using ParkingManagerSystem.BO;
using ParkingManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BLL
{
	public class ReservationBLL
	{
		private readonly ReservationDAL _db;

		public ReservationBLL()
		{
			_db = new ReservationDAL();
		}
		public bool Insert(ReservationBO block)
		{
			return _db.Add(block);
		}
		public IEnumerable<ReservationBO> GetAll()
		{
			return _db.GetAll();
		}
	}
}
