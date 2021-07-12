using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TitleAPI.Models
{
	[DataContract]
	public class Awards
	{
		[DataMember]
		public int TitleId { get; set; }
		[DataMember]
		public string TitleName { get; set; }
		[DataMember]
		public bool AwardWon { get; set; }
		[DataMember]
		public int AwardYear { get; set; }
		[DataMember]
		public string Award { get; set; }
		[DataMember]
		public string AwardCompany { get; set; }
		[DataMember]
		public int Id { get; set; }
	}
}
