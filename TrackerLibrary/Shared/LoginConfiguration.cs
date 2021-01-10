using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Shared
{
    public class LoginConfiguration
    {
        public LoginResolutionPolicy ResolutionPolicy { get; set; } = LoginResolutionPolicy.Username;
    }
}
