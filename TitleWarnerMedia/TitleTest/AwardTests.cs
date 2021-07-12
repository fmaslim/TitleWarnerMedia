using Microsoft.VisualStudio.TestTools.UnitTesting;
using TitleAPI;
using TitleAPI.Interfaces;

namespace TitleTest
{
	[TestClass]
	public class AwardTests
	{
		private string connectionString = "Server=localhost; Initial Catalog=Titles; Trusted_Connection=True;";
		[TestMethod]
		public void GetAllAwardsTest()
		{
			IRepository repo = new Repository();
			repo.ConnectionString = connectionString;

			var allAwards = repo.GetAllAwards();

			Assert.IsNotNull(allAwards);
		}

		[TestMethod]
		public void GetTitlesByGenreIdTest()
		{
			IRepository repo = new Repository();
			repo.ConnectionString = connectionString;

			var titlesByGenre = repo.GetTitlesByGenreId(1); // 1 - Adaptation

			Assert.IsNotNull(titlesByGenre);
		}

		[TestMethod]
		public void GetTitleParticipantsByTitleIdTest()
		{
			IRepository repo = new Repository();
			repo.ConnectionString = connectionString;

			var titleParticipants = repo.GetTitleParticipantsByTitleId(67079);

			Assert.IsNotNull(titleParticipants);
		}

		[TestMethod]
		public void GetAllTitlesTest()
		{
			IRepository repo = new Repository();
			repo.ConnectionString = connectionString;

			var allTitles = repo.GetAllTitles();

			Assert.IsNotNull(allTitles);
		}

		[TestMethod]
		public void GetAwardsByTitleIdTest()
		{
			IRepository repo = new Repository();
			repo.ConnectionString = connectionString;

			var allTitles = repo.GetAwardsByTitleId(70523);

			Assert.IsNotNull(allTitles);
		}
	}
}
