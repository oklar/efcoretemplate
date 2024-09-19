using MemberPlatform.DataAccess;
using MemberPlatform.Domain;
using Microsoft.AspNetCore.Mvc;

namespace MemberPlatform.Controllers;

[ApiController]
[Route("members")]
public class MemberController(MemberDbContext dbContext) : ControllerBase
{
    [HttpPost("")]
    public async Task<ActionResult> Create()
    {
        var m = new Member("hello");
        dbContext.Members.Add(m);
        await dbContext.SaveChangesAsync();
        return Created();
    }
}
