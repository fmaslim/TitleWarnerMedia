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
	public class OtherNameController : ControllerBase
	{
		public IRepository Repo { get; set; }
		public OtherNameController(IRepository repo)
		{
			Repo = repo;
		}

		// GET: api/<OtherNameController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<OtherNameController>/5
		[HttpGet("{titleId}")]
		public IActionResult Get(int titleId)
		{
			try
			{
				var otherName = Repo.GetOtherNameByTitleId(titleId);
				return Ok(otherName);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		// POST api/<OtherNameController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<OtherNameController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<OtherNameController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
