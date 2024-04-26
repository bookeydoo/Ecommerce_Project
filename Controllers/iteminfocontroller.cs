
using ecommerce_api.Models;
using ecommerce_api.Repository;
using Microsoft.AspNetCore.Mvc;


namespace ecommerce_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Iteminfocontroller:Controller
    {
        private readonly Repo repo1;
        public Iteminfocontroller(Repo repo)
        {
            repo1 = repo;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Storeitems>))]
        public IActionResult getstoredata()
        {
            var user_data=repo1.GetStoreitems();
            if(!ModelState.IsValid) { return BadRequest(ModelState); }
            return Ok(user_data);
        }
    }


}
