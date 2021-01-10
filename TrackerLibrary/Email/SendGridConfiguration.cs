using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Email
{
    public class SendGridConfiguration
    {
        public string ApiKey { get; set; }
        public string SourceEmail { get; set; }
        public string SourceName { get; set; }
        public bool EnableClickTracking { get; set; } = false;
    }
}
