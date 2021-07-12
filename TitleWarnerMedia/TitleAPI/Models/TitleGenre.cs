using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TitleAPI.Models
{
	[DataContract]
	public class TitleGenre
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public int TitleId { get; set; }
		[DataMember]
		public string TitleName { get; set; }
		[DataMember]
		public int GenreId { get; set; }
		[DataMember]
		public string GenreName { get; set; }
	}
}
