using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TitleAPI.Models
{
	[DataContract]
	public class OtherName
	{
		[DataMember]
		public int TitleId { get; set; }
		[DataMember]
		public string TitleNameLanguage { get; set; }
		[DataMember]
		public string TitleNameType { get; set; }
		[DataMember]
		public string TitleNameSortable { get; set; }
		[DataMember]
		public string TitleName { get; set; }
		[DataMember]
		public int Id { get; set; }
	}
}
