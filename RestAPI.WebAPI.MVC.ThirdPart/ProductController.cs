using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Model.Models;

namespace RestAPI.WebAPI.MVC.ThirdPart
{
    [Route("api/[controller]")]
    [ApiController]

    // First Solution With DI in Constructor

    #region First Solution
    //public class ProductController : ControllerBase
    //{
    //    //Use Dependency Injection
    //    #region Dependency Injection
    //    private readonly SampleRestApiContext dbcontext;

    //    public ProductController(SampleRestApiContext dbcontext) => this.dbcontext = dbcontext;

    //    #endregion

    //    public IActionResult GetAllProducts() => Ok(dbcontext.Products.ToList());

    //}
    #endregion



    // Second Solution With DI in Method

    #region Second Solution
    public class ProductController : ControllerBase
    {
        //Use Dependency Injection
        //private readonly SampleRestApiContext dbcontext;

        //public ProductController(SampleRestApiContext dbcontext) => this.dbcontext = dbcontext;

        #region Dependency Injection
        public IActionResult GetAllProducts([FromServices] SampleRestApiContext dbcontext) => Ok(dbcontext.Products.ToList());

        //Prevent circular reference
        [HttpGet("/api/Product/ProductWithBrand")]
        public IActionResult GetProducts([FromServices] SampleRestApiContext dbcontext)
        {
             var product = dbcontext.Products.Include(c => c.brand).ToList();
            foreach (var item in product)
            {
                item.brand.Products = null;
            }
            return Ok(product);
        }

        [HttpGet("/api/GetProduct/{id}")]
        public IActionResult GetProduct([FromServices] SampleRestApiContext dbcontext, int id)
        {
            var product = dbcontext.Products.Where(c => c.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        #endregion

    }
    #endregion


}
