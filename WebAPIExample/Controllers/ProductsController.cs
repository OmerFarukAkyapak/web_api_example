using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIExample.Model;
using WebSiteExample.Models;

namespace WebAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Context db = new Context();
        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            List<Products> products = new List<Products>();
            products = db.ProductsTable.ToList();
            if (products != null)
            {
                return Ok(products);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("[action]")]
        public IActionResult AddProduct(Products product)
        {
            db.Add(product);
            db.SaveChanges();
            return Ok("Adding Product is Succesfully !");
        }

        [HttpGet("[action]/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = db.ProductsTable.Where(x => x.id == id).FirstOrDefault();
            db.Remove(product);
            db.SaveChanges();
            return Ok("Deleting Product is Succesfully !");
        }
    }
}
