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
        public IActionResult Index()
        {
            var model = new List<NotificationTypeFormVM>()
            {
                new NotificationTypeFormVM(){ Id = 1, Name = "Jonny Depp", Description = "lorem ipson the description of the email notification is displayed"},
                new NotificationTypeFormVM(){ Id = 2, Name = "Bella Bell", Description = "lorem ipson the description of the email notification is displayed"},
                new NotificationTypeFormVM(){ Id = 3, Name = "Count Duke", Description = "lorem ipson the description of the email notification is displayed"},
                new NotificationTypeFormVM(){ Id = 4, Name = "OBiwan Kenobi", Description = "lorem ipson the description of the email notification is displayed"},
                new NotificationTypeFormVM(){ Id = 5, Name = "Han Solo", Description = "lorem ipson the description of the email notification is displayed"},
                new NotificationTypeFormVM(){ Id = 6, Name = "William Depp", Description = "lorem ipson the description of the email notification is displayed"},
                new NotificationTypeFormVM(){ Id = 7, Name = "Edgar Alen Poe", Description = "lorem ipson the description of the email notification is displayed"},
                new NotificationTypeFormVM(){ Id = 8, Name = "Davinci Leonardo", Description = "lorem ipson the description of the email notification is displayed"},
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult PostNotification()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostNotification([FromBody] NotificationTypeFormVM notificationTypeFormVM)
        {
            return View();
        }
    }
}
