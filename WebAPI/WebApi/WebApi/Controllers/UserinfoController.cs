using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using WebApi.Classes;
using WebApi.Service;


[ApiController]
[Route("api/[controller]")]
public class UserinfoController : ControllerBase
{
    private readonly UserdataInterface _UserService;

    public UserinfoController(UserdataInterface UserService)
    {
        _UserService = UserService;
    }

    [HttpGet]
    public IActionResult Getuserdata()
    {
        var item = _UserService.GetUserdatas();
        return Ok(item);
    }
}
