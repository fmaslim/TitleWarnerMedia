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
	public class TitleController : ControllerBase
	{
		public IRepository Repo { get; set; }

		public TitleController(IRepository repo)
		{
			Repo = repo;
		}

		// GET: api/<TitleController>
		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				var allTitles = Repo.GetAllTitles();
				return Ok(allTitles);
			}
			catch(Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		// GET api/<TitleController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<TitleController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<TitleController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<TitleController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
