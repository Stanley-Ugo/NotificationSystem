using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationSystem.ViewModel.ViewModels.NotificationChannelVM;


namespace NotificationSystem.API.Controllers
{
    public class NotificationChannelController : Controller
    {
        //Index Page View
        public IActionResult Index()
        {
            return View();
        }
    }
}
