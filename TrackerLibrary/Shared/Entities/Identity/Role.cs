using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerAuthAdmin.Configuration.Identity
{
    public class Role
    {
        public string Name { get; set; }
        public List<Claim> Claims { get; set; } = new List<Claim>();
    }
}
