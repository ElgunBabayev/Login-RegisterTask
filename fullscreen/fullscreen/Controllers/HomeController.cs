
using fullscreen.DAL;
using fullscreen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace fullscreen.Controllers
{
    public class HomeController : Controller
    {
        private readonly BauenDbContext db;
        public HomeController(BauenDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                Homes = db.Homes.ToList(),
                Abouts = db.Abouts.FirstOrDefault(),
                Projects = db.Projects.ToList(),

            };
            return View(hvm);
            
        }

    }
}
