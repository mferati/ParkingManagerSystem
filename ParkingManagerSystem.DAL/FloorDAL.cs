using ParkingManagerSystem.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBConfig = ParkingManagerSystem.DAL.DBConfigDAL;
using DAO = ParkingManagerSystem.DAL.DataAccessObject;

namespace ParkingManagerSystem.DAL
{
	public class FloorDAL : DataAccessLayer<FloorBO>
	{
		public bool Add(FloorBO model)
		{
			try
			{
				using (IDbConnection connection = DBConfig.GetConnection())
				{
					connection.Open();
					String sql = "Add_Floor";
					using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
					{
						DAO.AddParameter(command, "block_code", model.Block_Code);
						DAO.AddParameter(command, "floor_code", model.Floor_Code);
						DAO.AddParameter(command, "is_Floor_Full", model.is_Floor_Full);
						DAO.AddParameter(command, "is_Reserved", model.is_Reserved);
						DAO.AddParameter(command, "number_of_slots", model.Number_of_slots);

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

		public IEnumerable<FloorBO> GetAll()
		{
			using (IDbConnection connection = DBConfig.GetConnection())
			{
				connection.Open();
				List<FloorBO> floors = null;
				String sql = "GetAllFloors";
				using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
				{
					using (IDataReader reader = command.ExecuteReader())
					{
						floors = new List<FloorBO>();
						while (reader.Read())
						{
							floors.Add(ToObject(reader));
						}
					}

					return floors;

				}
			}
		}

		public FloorBO ToObject(IDataReader reader)
		{
			try
			{
				FloorBO floor = new FloorBO();
				floor.Block_Code = (int)reader["block_code"];
				if (reader["floor_code"] != DBNull.Value)
					floor.Floor_Code = (int)reader["floor_code"];
				if (reader["number_of_slots"] != DBNull.Value)
					floor.Number_of_slots = (int)reader["number_of_slots"];
				if (reader["is_Floor_Full"] != DBNull.Value)
					floor.is_Floor_Full = (bool)reader["is_Floor_Full"];
				if (reader["is_Reserved"] != DBNull.Value)
					floor.is_Reserved = (bool)reader["is_Reserved"];

				return floor;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public bool Modify(FloorBO model)
		{
			throw new NotImplementedException();
		}

		public bool Remove(FloorBO model)
		{
			throw new NotImplementedException();
		}

		FloorBO DataAccessLayer<FloorBO>.Get(int id)
		{
			throw new NotImplementedException();
		}

		public FloorBO Get(FloorBO model)
		{
			throw new NotImplementedException();
		}

		FloorBO DataAccessLayer<FloorBO>.ToObject(IDataReader reader)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int id)
		{
			throw new NotImplementedException();
		}
	}
}
