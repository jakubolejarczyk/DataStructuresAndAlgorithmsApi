using DataStructuresAndAlgorithmsApi.Models;
using DataStructuresAndAlgorithmsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataStructuresAndAlgorithmsApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SingleLinkedListController(SingleLinkedListService service) : ControllerBase
{
    [HttpPost("/append/{value}")]
    public ActionResult<string> Append(int value)
    {
        service.Append(value);
        return Ok("Node successfully append to the single linked list");
    }

    [HttpPost("/prepend/{value}")]
    public ActionResult<string> Prepend(int value)
    {
        service.Prepend(value);
        return Ok("Node successfully append to the single linked list");
    }

    [HttpGet("/find/{value}")]
    public ActionResult<int?> Find(int value)
    {
        var node = service.Find(value);
        return Ok(node);
    }

    [HttpGet("/tolist")]
    public ActionResult<List<int>> ToList()
    {
        var list = service.ToList();
        return Ok(list);
    }
}
