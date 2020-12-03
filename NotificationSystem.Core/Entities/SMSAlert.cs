using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSystem.Core.Entities
{
    public class SMSAlert
    {
        public long Id { get; set; }
        public string MobileNo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string ReceiverName { get; set; }

        //public UserType Usertype { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateProcessed { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string CreatedBy { get; set; }
        public int Sendtries { get; set; }
    }
}
