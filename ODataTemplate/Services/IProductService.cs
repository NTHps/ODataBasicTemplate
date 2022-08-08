using ODataTemplate.Models;

namespace ODataTemplate.Services
{
    public interface IProductService
    {
        IQueryable<Product> RetrieveProducts();
    }
}
