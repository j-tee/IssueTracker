using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackerAuthAdmin.Configuration.Identity;

namespace TrackerAuthAdmin.Configuration
{
    public class IdentityDataConfiguration
    {
        public List<Role> Roles { get; set; }
        public List<User> Users { get; set; }
    }
}
