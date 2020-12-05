using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NotificationSystem.API.Controllers
{
    public class NotificationChannelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PostNotification()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostNotification()
        {
            return View();
        }
    }
}
