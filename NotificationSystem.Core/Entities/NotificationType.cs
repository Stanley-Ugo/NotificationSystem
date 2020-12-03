using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSystem.Core.Entities
{
    public class NotificationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
