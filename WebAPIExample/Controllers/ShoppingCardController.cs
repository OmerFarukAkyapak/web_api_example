using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPIExample.Model;
using WebSiteExample.Models;


namespace WebAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCardController : ControllerBase
    {
        Context db = new Context();

        [HttpGet("[action]")]
        public IActionResult GetList() 
        {
            var result = db.ProductsCard.ToList();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("[action]")]
        public IActionResult AddCardProduct(ShoppingCard card)
        {
            db.Add(card);
            db.SaveChanges();
            return Ok("Adding product to Card is Successfully !");
        }

        [HttpGet("[action]/{id}")]
        public IActionResult DeleteCardProduct(int id)
        {
            var result = db.ProductsCard.Where(x => x.id == id).FirstOrDefault();
            db.ProductsCard.Remove(result);
            db.SaveChanges();

            return Ok("Deleting product to Card is Successfully !");
        }

    }
}
