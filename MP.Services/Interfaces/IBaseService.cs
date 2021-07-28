using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Services.Interfaces
{
	public interface IBaseService<T> where T : class
	{
		Task<IEnumerable<T>> GetAll();
		Task<T> GetById(object id);
		Task<T> Insert(T entity);
		Task Update(T entity);
		Task Delete(T entity);
	}
}
