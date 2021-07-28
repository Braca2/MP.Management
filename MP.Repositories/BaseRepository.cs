using Microsoft.EntityFrameworkCore;
using MP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		private readonly DbContext context;
		private readonly DbSet<T> entities;

		public BaseRepository(DbContext context)
		{
			this.context = context;
			entities = context.Set<T>();
		}

		public Task Delete(T entity)
		{
			if (entity == null)
				throw new ArgumentNullException(nameof(entity));

			entities.Remove(entity);
			context.SaveChanges();
			return Task.CompletedTask;
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			return await context.Set<T>().ToListAsync();
		}

		public async Task<T> GetById(object id)
		{
			return await context.FindAsync<T>(id);
		}

		public async Task<T> Insert(T entity)
		{
			if (entity == null)
				throw new ArgumentNullException(nameof(entity));

			context.Add(entity);
			await context.SaveChangesAsync();

			return entity;
		}

		public async Task Update(T entity)
		{
			if (entity == null)
				throw new ArgumentNullException(nameof(entity));

			var value = context
				.Entry(entity)
				.Metadata
				.FindPrimaryKey().Properties
				.Select(p => context.Entry(entity).Property(p.Name).CurrentValue)
				.FirstOrDefault();

			var old = context.Find<T>(value);

			context.Entry(old).CurrentValues.SetValues(entity);

			await context.SaveChangesAsync();
		}
	}
}
