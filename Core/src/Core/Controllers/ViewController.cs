using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Model;

namespace Core.Controllers
{
    public class ViewController : Controller
    {
        private CrudContext context;
        public ViewController(CrudContext context)
        {
            this.context = context;
        }       
         
        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult Error()
        {
            return View("index");
        }
    }
}
