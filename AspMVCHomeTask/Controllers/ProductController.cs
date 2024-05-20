using AspMVCHomeTask.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCHomeTask.Controllers
{
    public class ProductController : Controller
    {
		private readonly AppDbContext _context;

		public ProductController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var products = await _context.Products.ToListAsync();
			return View(products);
		}
	}
}
