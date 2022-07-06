using HomeTaskBootstrapVesperr.DAL;
using HomeTaskBootstrapVesperr.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskBootstrapVesperr.Controllers
{
    public class HomeController:Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Services> services = _context.Services.ToList();

            return View(services);
        }

        public IActionResult ServicesDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Services services = _context.Services.FirstOrDefault(b => b.Id ==id);
            return View(services);
        }
    }
}
