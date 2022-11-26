using System.Collections.Generic;
using CanWeFixItService;
using Microsoft.AspNetCore.Mvc;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/marketdata")]
    public class MarketDataController : ControllerBase
    {
	    private readonly IDatabaseService _database;

	    public MarketDataController(IDatabaseService database)
	    {
		    _database = database;
	    }

	    // GET
	    public ActionResult<IEnumerable<MarketDataDto>> Get()
	    {
		    var result = _database.MarketData().Result;
			return Ok(result);
	    }
	}
}