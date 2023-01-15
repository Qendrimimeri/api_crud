using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ToDoController : ControllerBase
{
    [HttpPost("addtodo")]
    public IActionResult AddToDo(ToDoModel model)
    {
        return Ok(model);
    }
}
