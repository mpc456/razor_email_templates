using System;
using System.Collections.Generic;
using System.Text;

namespace RazorLibrary.Model
{
    public class NotificationCollection
    {
        public IEnumerable<NotificationModel> Notifications { get; set; }
    }
}
