using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Classes;
using WebApi.Interfaces;
using WebApi.Service;


[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IitemsInterface _itemsService;

    public ItemsController(IitemsInterface itemsService)
    {
        _itemsService = itemsService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        var item = _itemsService.GetItems();
        return Ok(item);
    }
}
