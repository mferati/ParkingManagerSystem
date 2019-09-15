using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagerSystem.BO
{
	public interface DataAccessLayer<T> where T : class
	{
		//void Add(T model);
		bool Add(T model);
		bool Modify(T model);
		bool Remove(int id);
		bool Remove(T model);

		T Get(int id);
		T Get(T model);
		IEnumerable<T> GetAll();

		T ToObject(IDataReader reader);

		//int Add(T model);


	}
}
