﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerAuthAdmin.Configuration.IdentityServer.Helpers
{
    public class NotificationHelpers
    {
        public const string NotificationKey = "IdentityServerAdmin.Notification";

        public class Alert
        {
            public AlertType Type { get; set; }
            public string Message { get; set; }
            public string Title { get; set; }
        }

        public enum AlertType
        {
            Info,
            Success,
            Warning,
            Error
        }
    }
}
