using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationSystem.ViewModel.ViewModels.NotificationSMSAlertVM;


namespace NotificationSystem.API.Controllers
{
    public class NotificationSMSAlertController : Controller
    {
        //index View Page
        public IActionResult Index()
        {
            return View();
        }

    }
}
