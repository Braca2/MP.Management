using MP.Repositories.Interfaces;
using MP.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MP.Services
{
	public class EmployeeService<T> : IBaseService<T> where T : class
	{
		private readonly IBaseRepository<T> baseRepository;

		public EmployeeService(IBaseRepository<T> baseRepository)
		{
			this.baseRepository = baseRepository;
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			return await baseRepository.GetAll();
		}

		public async Task<T> GetById(object id)
		{
			return await baseRepository.GetById(id);
		}

		public async Task<T> Insert(T entity)
		{
			return await baseRepository.Insert(entity);
		}

		public async Task Update(T entity)
		{
			await baseRepository.Update(entity);
		}

		public async Task Delete(T entity)
		{
			await baseRepository.Delete(entity);
		}
	}
}
