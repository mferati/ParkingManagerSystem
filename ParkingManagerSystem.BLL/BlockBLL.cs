using ParkingManagerSystem.BO;
using ParkingManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BLL
{
	public class BlockBLL
	{
		private readonly BlockDAL _db;

		public BlockBLL()
		{
			_db = new BlockDAL();
		}
		public bool Insert(BlockBO block)
		{
			return _db.Add(block);
		}
		public IEnumerable<BlockBO> GetAll()
		{
			return _db.GetAll();
		}
	}
}
