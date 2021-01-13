using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerAuthAdmin.Configuration.IdentityServer.Helpers
{
    public class OpenIdProfile
    {
        public string FullName { get; internal set; }
        public string Website { get; internal set; }
        public string Profile { get; internal set; }
        public string StreetAddress { get; internal set; }
        public string Locality { get; internal set; }
        public string Region { get; internal set; }
        public string PostalCode { get; internal set; }
        public string Country { get; internal set; }
    }
}
