using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using oopAPI.Interfaces;
using oopAPI.Models;
namespace oopAPI.Controllers

{
    [Route("api/Items")]
    [ApiController]
    public class ItemsController : Controller

    {
        private readonly IItemsRepositary _itemsRepositary;
        public ItemsController(IItemsRepositary itemsRepositary)
        {
            _itemsRepositary = itemsRepositary;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Items>))]
        public IActionResult Getitems()
        {
            var items = _itemsRepositary.GetItems();
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(items);
        }



    }
}
