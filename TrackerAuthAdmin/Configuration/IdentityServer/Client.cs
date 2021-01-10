using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackerAuthAdmin.Configuration.Identity;

namespace TrackerAuthAdmin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}
