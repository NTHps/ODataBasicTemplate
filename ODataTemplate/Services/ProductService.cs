using ODataTemplate.Models;

namespace ODataTemplate.Services
{
    
    public class ProductService : IProductService
    {
        public IQueryable<Product> RetrieveProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = 6,
                    Category = "Category 1"
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 1,
                    Category = "Category 2"
                },
                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Price = 3,
                    Category = "Category 3"
                },
            }.AsQueryable();
        }
    }
    
}
