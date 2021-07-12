using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitleAPI.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TitleAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TitleParticipantController : ControllerBase
	{
		public IRepository Repo { get; set; }
		public TitleParticipantController(IRepository repo)
		{
			Repo = repo;
		}
		// GET: api/<TitleParticipant>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<TitleParticipant>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			try
			{
				var titleParticipants = Repo.GetTitleParticipantsByTitleId(id);
				return Ok(titleParticipants);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		// POST api/<TitleParticipant>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<TitleParticipant>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<TitleParticipant>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
