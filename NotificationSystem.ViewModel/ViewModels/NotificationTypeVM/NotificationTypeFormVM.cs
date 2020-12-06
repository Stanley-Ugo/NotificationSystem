using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NotificationSystem.ViewModel.ViewModels.NotificationTypeVM
{
    public class NotificationTypeFormVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
