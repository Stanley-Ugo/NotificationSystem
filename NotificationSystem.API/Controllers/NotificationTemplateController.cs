﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotificationSystem.ViewModel.ViewModels.NotificationTemplateVM;


namespace NotificationSystem.API.Controllers
{
    public class NotificationTemplateController : Controller
    {
        //Index Page View
        public IActionResult Index()
        {
            return View();
        }

        //Post Notification Get
        [HttpGet]
        public IActionResult PostNotification()
        {
            return View();
        }

        //Post Notification Post
        [HttpPost]
        public IActionResult PostNotification([FromBody] NotificationTemplateFormVM notificationTemplateFormVM)
        {
            return View();
        }
    }
}
