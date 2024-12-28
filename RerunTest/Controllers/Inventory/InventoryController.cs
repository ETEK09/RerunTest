using Microsoft.AspNetCore.Mvc;

namespace RerunTest.Controllers.Inventory
{
    public class InventoryController : Controller
    {
        private readonly IInventoryRepository repo;

        public InventoryController(IInventoryRepository repo) 
        {
        
           this.repo = repo;
        
        }
        public IActionResult Index()
        {
            var products = repo.GetAllInventory();
            return View(products);
        }

       
    }
}
