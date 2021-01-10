using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackerLibrary.Configurations.Common;
using TrackerLibrary.Configurations.Common.Interfaces;
using TrackerLibrary.Identity;

namespace TrackerAuthAdmin.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
        public IdentityServerDataConfiguration IdentityServerDataConfiguration { get; set; } = new IdentityServerDataConfiguration();
        public IdentityDataConfiguration IdentityDataConfiguration { get; set; } = new IdentityDataConfiguration();
    }
}
