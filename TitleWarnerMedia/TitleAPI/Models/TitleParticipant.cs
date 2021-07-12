using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TitleAPI.Models
{
	[DataContract]
	public class TitleParticipant
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public int TitleId { get; set; }
		[DataMember]
		public string TitleName { get; set; }
		[DataMember]
		public int ParticipantId { get; set; }
		[DataMember]
		public string ParticipantName { get; set; }
		[DataMember]
		public bool IsKey { get; set; }
		[DataMember]
		public string RoleType { get; set; }
		[DataMember]
		public bool IsOnScreen { get; set; }
	}
}
