using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationSystem.ViewModel.ViewModels.NotificationEmailAlertVM;


namespace NotificationSystem.API.Controllers
{
    public class NotificationEmailAlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
