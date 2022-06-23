using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ECommerceContext db;
        public ProductController(ECommerceContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return db.Products;
        }
    }
}