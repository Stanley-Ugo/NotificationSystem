using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationSystem.ViewModel.ViewModels.NotificationTypeVM;

namespace NotificationSystem.API.Controllers
{
    public class NotificationTypeController : Controller
    {
        //Index View
        public IActionResult Index()
        {
            return View();
        }

        //Get IActionResult
        [HttpGet]
        public IActionResult PostNotification()
        {
            return View();
        }

        //Post Method
        [HttpPost]
        public IActionResult PostNotification([FromBody] NotificationTypeFormVM notificationTypeFormVM)
        {
            return View();
        }
    }
}
