using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MADWORDS.Controllers
{
    public class UpdatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}