using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homvm = new HomeVM()
            {
                Sliders = await _db.Sliders.ToListAsync(),
                Services = await _db.Services.OrderByDescending(x=>x.Id).Skip(3).Take(3).ToListAsync(),
            FeedBacks = await _db.FeedBacks.ToListAsync(),
            Events= await _db.Events.Take(4).ToListAsync(),
            };
            return View(homvm);
        }
        

        public IActionResult Error()
        {
            return View();
        }
    }
}
