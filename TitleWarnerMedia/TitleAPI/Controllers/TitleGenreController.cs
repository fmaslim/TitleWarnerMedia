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
	public class TitleGenreController : ControllerBase
	{
		public IRepository Repo { get; set; }

		public TitleGenreController(IRepository repo)
		{
			Repo = repo;
		}
		// GET: api/<TitleGenreController>
		[HttpGet]
		public IActionResult Get()
		{
			return Ok();
		}

		// GET api/<TitleGenreController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			try
			{
				var titlesByGenre = Repo.GetTitlesByGenreId(id);
				return Ok(titlesByGenre);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		// POST api/<TitleGenreController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<TitleGenreController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<TitleGenreController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
