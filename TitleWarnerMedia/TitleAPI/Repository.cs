using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitleAPI.Interfaces;
using TitleAPI.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TitleAPI
{
	public class Repository : IRepository
	{
		private string _connectionString;
		public string ConnectionString 
		{ 
			get => string.IsNullOrEmpty(_connectionString) ? TitleAppSettings.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value : _connectionString;
			set => _connectionString = value;
		}

		public static Func<string, IDbConnection> CreateConnection = connectionString => new SqlConnection(connectionString);

		public Repository()
		{
		}

		public IEnumerable<TData> ExecuteStoredProcedure<TData>(string storedProcedureName, object parameters)
		{
			using (var connection = CreateConnection(ConnectionString))
			//using (var connection = CreateConnection("Server=localhost; Initial Catalog=Titles; Trusted_Connection=True;"))
			{
				return connection.Query<TData>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public IEnumerable<Awards> GetAllAwards()
		{
			try
			{
				return ExecuteStoredProcedure<Awards>("GetAllAwards", null);
			}
			catch
			{
				throw;
			}
		}

		public IEnumerable<TitleGenre> GetTitlesByGenreId(int genreId)
		{
			try
			{
				return ExecuteStoredProcedure<TitleGenre>("GetTitlesByGenreId", new { genreId });
			}
			catch
			{
				throw;
			}
		}

		public IEnumerable<TitleParticipant> GetTitleParticipantsByTitleId(int titleId)
		{
			try
			{
				return ExecuteStoredProcedure<TitleParticipant>("GetTitleParticipantsByTitleId", new { titleId });
			}
			catch
			{
				throw;
			}
		}

		public IEnumerable<Title> GetAllTitles()
		{
			try
			{
				return ExecuteStoredProcedure<Title>("GetAllTitles", null);
			}
			catch
			{
				throw;
			}
		}

		public IEnumerable<Awards> GetAwardsByTitleId(int titleId)
		{
			try
			{
				return ExecuteStoredProcedure<Awards>("GetAwardsByTitleId", new { titleId });
			}
			catch
			{
				throw;
			}
		}

		public IEnumerable<OtherName> GetOtherNameByTitleId(int titleId)
		{
			try
			{
				return ExecuteStoredProcedure<OtherName>("GetOtherNameByTitleId", new { titleId });
			}
			catch
			{
				throw;
			}
		}
	}
}
