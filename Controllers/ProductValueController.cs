using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    [Route("api/products")]
    public class ProductValueController : Controller
    {
        private readonly DataContext _context;

        public ProductValueController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Product GetProduct(long id)
        {
            var result = _context.Products
                .Include(p => p.Supplier).ThenInclude(s => s.Products)
                .Include(p => p.Ratings)
                .FirstOrDefault(p => 
                    p.ProductId == id);

            if (result == null)
                return null;

            if (result.Supplier != null)
                result.Supplier.Products = result.Supplier.Products.Select(p => new Product
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Category = p.Category,
                    Description = p.Description,
                    Price = p.Price
                });

            if (result.Ratings == null) 
                return result;
            
            foreach (var r in result.Ratings)
            {
                r.Product = null;
            }

            return result;
        }
    }
}