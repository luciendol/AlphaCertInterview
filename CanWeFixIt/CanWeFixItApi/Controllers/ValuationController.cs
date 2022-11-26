using CanWeFixItService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CanWeFixItApi.Controllers
{
	[ApiController]
	[Route("v1/valuations")]
	public class ValuationController : Controller
	{
		private readonly IDatabaseService _database;

		public ValuationController(IDatabaseService database)
		{
			_database = database;
		}

		// GET
		public ActionResult<IEnumerable<MarketValuation>> Get()
		{
			var result = _database.MarketValuation().Result;
			return Ok(result);
		}
	}
}
