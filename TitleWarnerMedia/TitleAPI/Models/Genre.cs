using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TitleAPI.Models
{
	[DataContract]
	public class Genre
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }		
	}
}
