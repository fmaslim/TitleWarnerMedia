using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TitleAPI.Models
{
	[DataContract]
	public class StoryLine
	{
		[DataMember]
		public int TitleId { get; set; }
		[DataMember]
		public string	 Type { get; set; }
		[DataMember]
		public string Language { get; set; }
		[DataMember]
		public string Description { get; set; }
		[DataMember]
		public int Id { get; set; }
	}
}
