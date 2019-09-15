using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBConfig = ParkingManagerSystem.DAL.DBConfigDAL;
using DAO = ParkingManagerSystem.DAL.DataAccessObject;
using ParkingManagerSystem.BO;
using System.Data;

namespace ParkingManagerSystem.DAL
{
	public class ParkingSlotDAL : DataAccessLayer<ParkingSlotsBO>
	{
		public bool Add(ParkingSlotsBO model)
		{
			try
			{
				using (IDbConnection connection = DBConfig.GetConnection())
				{
					connection.Open();
					String sql = "Add_ParkingSlot";
					using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
					{
						DAO.AddParameter(command, "slot_code", model.SlotCode);
						DAO.AddParameter(command, "floor_code", model.FloorCode);
						DAO.AddParameter(command, "is_reserved", model.is_reserved);

						var result = command.ExecuteNonQuery();
						return result >= 0;
					}
				}
			}
			catch (Exception e)
			{
				return false;
			}
		}

		public ParkingSlotsBO Get(int id)
		{
			throw new NotImplementedException();
		}

		public ParkingSlotsBO Get(ParkingSlotsBO model)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ParkingSlotsBO> GetAll()
		{
			using (IDbConnection connection = DBConfig.GetConnection())
			{
				connection.Open();
				List<ParkingSlotsBO> parkingSlots = null;
				String sql = "GetAllParkingSlots";
				try
				{
					using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
					{
						using (IDataReader reader = command.ExecuteReader())
						{
							parkingSlots = new List<ParkingSlotsBO>();
							while (reader.Read())
							{
								parkingSlots.Add(ToObject(reader));
							}
						}

						return parkingSlots;

					}

				}
				catch (Exception ex)
				{
					throw;
				}

			}
		}

		public bool Modify(ParkingSlotsBO model)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int id)
		{
			throw new NotImplementedException();
		}

		public bool Remove(ParkingSlotsBO model)
		{
			throw new NotImplementedException();
		}

		public ParkingSlotsBO ToObject(IDataReader reader)
		{
			try
			{
				ParkingSlotsBO parkingSlot = new ParkingSlotsBO();
				parkingSlot.FloorCode = (int)reader["floor_code"];
				if (reader["is_reserved"] != DBNull.Value)
					parkingSlot.is_reserved = (bool)reader["is_reserved"];
				if (reader["slot_code"] != DBNull.Value)
					parkingSlot.SlotCode = (int)reader["slot_code"];

				return parkingSlot;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
		
	}
}
