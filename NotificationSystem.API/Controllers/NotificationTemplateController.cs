using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationSystem.ViewModel.ViewModels.NotificationTemplateVM;


namespace NotificationSystem.API.Controllers
{
    public class NotificationTemplateController : Controller
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
        public IActionResult PostNotification([FromBody] NotificationTemplateFormVM notificationTemplateFormVM)
        {
            return View();
        }
    }
}
