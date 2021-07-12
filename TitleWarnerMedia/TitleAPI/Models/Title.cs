using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TitleAPI.Models
{
	[DataContract]
	public class Title
	{
		[DataMember]
		public int TitleId { get; set; }
		[DataMember]
		public string TitleName { get; set; }
		[DataMember]
		public string TitleNameSortable { get; set; }
		[DataMember]
		public int TitleTypeId { get; set; }
		[DataMember]
		public int ReleaseYear { get; set; }
		[DataMember]
		public DateTime ProcessedDateTimeUTC { get; set; }
	}
}
