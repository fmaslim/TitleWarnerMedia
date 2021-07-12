using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitleAPI.Models;

namespace TitleAPI.Interfaces
{
	public interface IRepository
	{
		public string ConnectionString { get; set; }
		public IEnumerable<Awards> GetAllAwards();
		public IEnumerable<TitleGenre> GetTitlesByGenreId(int genreId);
		public IEnumerable<TitleParticipant> GetTitleParticipantsByTitleId(int titleId);
		public IEnumerable<Title> GetAllTitles();
		public IEnumerable<Awards> GetAwardsByTitleId(int titleId);
		public IEnumerable<OtherName> GetOtherNameByTitleId(int titleId);
	}
}
