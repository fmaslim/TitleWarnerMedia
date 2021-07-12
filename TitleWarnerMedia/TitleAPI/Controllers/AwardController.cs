using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TitleAPI.Interfaces;
using TitleAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TitleAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AwardController : ControllerBase
	{
		public IRepository Repo { get; set; }
		public AwardController(IRepository repo)
		{
			Repo = repo;
		}
		// GET: api/<AwardController>
		[HttpGet]
		public IEnumerable<Awards> Get()
		{
			//IRepository repo = new Repository();
			var allAwards = Repo.GetAllAwards();

			return allAwards;
		}

		// GET api/<AwardController>/5
		[HttpGet("{titleId}")]
		[Route("title/{titleid}")]
		public IActionResult Get(int titleId)
		{
			try
			{
				var awardsByTitle = Repo.GetAwardsByTitleId(titleId);
				return Ok(awardsByTitle);
			}
			catch(Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		// POST api/<AwardController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<AwardController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<AwardController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
