using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagerSystem.BO;
using DBConfig = ParkingManagerSystem.DAL.DBConfigDAL;
using DAO = ParkingManagerSystem.DAL.DataAccessObject;
using System.Data;

namespace ParkingManagerSystem.DAL
{
	public class ReservationDAL : DataAccessLayer<ReservationBO>
	{
		public bool Add(ReservationBO model)
		{
			try
			{
				using (IDbConnection connection = DBConfig.GetConnection())
				{
					String sql = "dbo.usp_Employee_Insert";
					using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
					{
						DAO.AddParameter(command, "vehicle_number", model.vehicle_number);
						DAO.AddParameter(command, "reservation_date", model.reservation_date);
						DAO.AddParameter(command, "parking_slot_code", model.SlotCode);

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

		public IEnumerable<ReservationBO> GetAll()
		{
			using (IDbConnection connection = DBConfig.GetConnection())
			{
				connection.Open();
				List<ReservationBO> reservations = null;
				String sql = "GetAllReservations";
				using (IDbCommand command = DBConfig.Command(connection, sql, CommandType.StoredProcedure))
				{
					using (IDataReader reader = command.ExecuteReader())
					{
						reservations = new List<ReservationBO>();
						while (reader.Read())
						{
							reservations.Add(ToObject(reader));
						}
					}

					return reservations;

				}
			}
		}



		public ReservationBO ToObject(IDataReader reader)
		{
			try
			{
				ReservationBO reservation = new ReservationBO();

				if (reader["vehicle_number"] != DBNull.Value)
					reservation.vehicle_number = (int)reader["vehicle_number"];
				if (reader["reservation_date"] != DBNull.Value)
					reservation.reservation_date = (DateTime)reader["reservation_date"];
				if (reader["parking_slot_code"] != DBNull.Value)
					reservation.SlotCode = (int)reader["parking_slot_code"];

				return reservation;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public ReservationBO Get(int id)
		{
			throw new NotImplementedException();
		}

		public ReservationBO Get(ReservationBO model)
		{
			throw new NotImplementedException();
		}


		public bool Modify(ReservationBO model)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int id)
		{
			throw new NotImplementedException();
		}

		public bool Remove(ReservationBO model)
		{
			throw new NotImplementedException();
		}
	}
}
