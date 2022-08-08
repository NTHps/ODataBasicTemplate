using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataTemplate.Models;
using ODataTemplate.Services;

namespace ODataTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<Product>> GetAllProducts()
        {
            IQueryable<Product> retrievedPrdoucts = this.productService.RetrieveProducts();
            return Ok(retrievedPrdoucts);
        }
        
    }
}
