using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerAuthAdmin.Configuration;
using TrackerLibrary.Identity;

namespace TrackerLibrary.Configurations.Common.Interfaces
{
    public interface IRootConfiguration
    {
        AdminConfiguration AdminConfiguration { get; }
        IdentityDataConfiguration IdentityDataConfiguration { get; }
        IdentityServerDataConfiguration IdentityServerDataConfiguration { get; }
        RegisterConfiguration RegisterConfiguration { get; }
    }
}
