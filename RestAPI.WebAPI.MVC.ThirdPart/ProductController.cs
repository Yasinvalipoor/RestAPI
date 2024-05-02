using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAllProducts([FromServices]SampleRestApiContext dbcontext) => Ok(dbcontext.Products.ToList());
        #endregion

    }
    #endregion


}
