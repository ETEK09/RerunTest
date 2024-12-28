using RerunTest.Models;

namespace RerunTest
{

    //The interface declares a set of methods that interacts with data such as querying, adding, updating, and deleting records///
    public interface IInventoryRepository
    {
        public IEnumerable<Inventory> GetAllInventory();

    }
}
