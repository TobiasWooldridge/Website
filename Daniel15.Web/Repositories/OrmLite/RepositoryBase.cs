﻿using System.Collections.Generic;
using System.Data;
using ServiceStack.OrmLite;

namespace Daniel15.Web.Repositories.OrmLite
{
	/// <summary>
	/// A base repository class that uses OrmLite as the data access component.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : new()
	{
		protected readonly IDbConnectionFactory _connectionFactory;
		private IDbConnection _connection;

		protected IDbConnection Connection
		{
			get { return _connection ?? (_connection = _connectionFactory.OpenDbConnection()); }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RepositoryBase{T}" /> class.
		/// </summary>
		/// <param name="conn">The conn.</param>
		public RepositoryBase(IDbConnectionFactory connectionFactory)
		{
			_connectionFactory = connectionFactory;
		}

		/// <summary>
		/// Gets all the entities in the database
		/// </summary>
		/// <returns></returns>
		public List<T> All()
		{
			return Connection.Select<T>();
		}

		/// <summary>
		/// Gets a particular entity from the database
		/// </summary>
		/// <param name="id">ID of the entity</param>
		/// <returns>The entity</returns>
		public T Get(int id)
		{
			return Connection.GetById<T>(id);
		}

		/// <summary>
		/// Saves this entity to the database
		/// </summary>
		/// <param name="entity">The entity to save</param>
		public void Save(T entity)
		{
			Connection.Save(entity);
		}
	}
}