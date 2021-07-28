using MP.Entities;
using MP.Repositories.Interfaces;
using MP.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace MP.Services
{
	public class ClientService<T> : IPersonService
	{
		private readonly IBaseRepository<Person> baseRepository;

		public ClientService(IBaseRepository<Person> baseRepository)
		{
			this.baseRepository = baseRepository;
		}

		public async Task<T> Get()
		{
			throw new NotImplementedException();
		}

		public async Task<Guid> Insert()
		{
			throw new NotImplementedException();
		}

		public async Task<T> Update()
		{
			throw new NotImplementedException();
		}

		public Task<bool> Delete()
		{
			throw new NotImplementedException();
		}
	}
}
