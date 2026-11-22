using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class ProductControler:Controller
    {
        [HttpGet]
        public IActionResult GetById([FromRoute (Name ="id")] int code,[FromQuery(Name ="id02")] int otherId)
        {
            return View();
        }






        [HttpGet]
        public IActionResult Search(ProductFilter filter)
        {
            return View();
        }

        //public IActionResult Search(string? term, decimal? minPrice, int page)
        //{
        //    return View();
        //}








        //public IActionResult Search([FromQuery] int  id)
        //{
        //    return View();
        //}










        //public ContentResult Index ()
        //{
        //    ContentResult result = new ContentResult()
        //    {
        //        Content = "<h1>hello</h1>",
        //        StatusCode = 200,
        //        ContentType = "text/plain",
        //    }
        //    ContentResult result = new ContentResult()
        //    {
        //        Content = "<h1>hello</h1>",
        //        StatusCode = 1000,
        //        ContentType = "text/html",
        //    };
        //    return Content("<h1>hello from Index</h1>", "text/html");


        //}
        //public ViewResult Index()
        //{
        //    return View();
        //}

        [HttpGet("Test/json")]

        public IActionResult JsonAction()
        {
            return Json("hello from json");
        }

        [HttpGet("Test/ProductCode")]
        public IActionResult GetProductByCode(int code) {
            return Json(new Product() { Id= code, Name = "Laptop" });
        }
       
        
    }
}
