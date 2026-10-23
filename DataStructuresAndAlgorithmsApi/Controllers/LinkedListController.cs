using DataStructuresAndAlgorithmsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataStructuresAndAlgorithmsApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LinkedListController(ILinkedListService service) : ControllerBase
{
    [HttpPost("{value}")]
    public ActionResult<string> PostAppend(int value)
    {
        service.Append(value);
        return Ok("Node successfully append");
    }

    [HttpGet]
    public ActionResult<string> GetText()
    {
        return Ok(service.GetText());
    }
}
