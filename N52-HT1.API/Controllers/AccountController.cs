using Microsoft.AspNetCore.Mvc;
using N52_HT1.API.Entities;
using N52_HT1.API.Services.Interface;

namespace N52_HT1.API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly IUserService _userService;

    public AccountController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(User user)
    {
        var result = await _userService.CreateAsync(user);
        return Ok(result);
    }
}