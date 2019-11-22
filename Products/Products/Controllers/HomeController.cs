using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Products.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Controllers
{
    public class HomeController : Controller
    {
        List<Product> p = LoadJson();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(p);
        }

        public static List<Product> LoadJson()
        {
            using (StreamReader r = new StreamReader(@"..\Products\Resources\products.json"))
            {
                //string json = r.ReadToEnd();
                List<Product> items = JsonConvert.DeserializeObject<List<Product>>(r.ReadToEnd());

                return items;
            }
        }
    }
}
