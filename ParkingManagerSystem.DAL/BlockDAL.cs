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
	public class BlockDAL : DataAccessLayer<BlockBO>
	{
		public bool Add(BlockBO model)
		{
			try
			{
				using (IDbConnection connection = DBConfig.GetConnection())
				{
					String sql = "dbo.usp_Employee_Insert";
					using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
					{
						// DAO = Data Access Object
						DAO.AddParameter(command, "number_of_floors", model.Number_of_floors);
						DAO.AddParameter(command, "block_code", model.BlockCode);
						DAO.AddParameter(command, "is_block_full", model.is_Block_full);
						
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

		public IEnumerable<BlockBO> GetAll()
		{
			using (IDbConnection connection = DBConfig.GetConnection())
			{
				connection.Open();
				List<BlockBO> blocks = null;
				String sql = "GetAllBlocks";
				using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
				{
					using (IDataReader reader = command.ExecuteReader())
					{
						blocks = new List<BlockBO>();
						while (reader.Read())
						{
							blocks.Add(ToObject(reader));
						}
					}

					return blocks;

				}
			}
		}

		public BlockBO ToObject(IDataReader reader)
		{
			try
			{
				BlockBO block = new BlockBO();

				if (reader["number_of_floors"] != DBNull.Value)
					block.Number_of_floors = (int)reader["number_of_floors"];
				if (reader["BlockCode"] != DBNull.Value)
					block.BlockCode = (int)reader["BlockCode"];
				if (reader["is_block_full"] != DBNull.Value)
					block.is_Block_full = (bool)reader["is_block_full"];
				return block;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public bool Remove(int id)
		{
			throw new NotImplementedException();
		}

		public bool Modify(BlockBO model)
		{
			throw new NotImplementedException();
		}

		public bool Remove(BlockBO model)
		{
			throw new NotImplementedException();
		}

		public BlockBO Get(int id)
		{
			throw new NotImplementedException();
		}

		public BlockBO Get(BlockBO model)
		{
			throw new NotImplementedException();
		}

		IEnumerable<BlockBO> DataAccessLayer<BlockBO>.GetAll()
		{
			throw new NotImplementedException();
		}

		BlockBO DataAccessLayer<BlockBO>.ToObject(IDataReader reader)
		{
			throw new NotImplementedException();
		}
	}
}
