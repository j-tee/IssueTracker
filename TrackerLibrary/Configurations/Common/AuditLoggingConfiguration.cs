using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Configurations.Common
{
    public class AuditLoggingConfiguration
    {
        public string Source { get; set; }

        public string SubjectIdentifierClaim { get; set; }

        public string SubjectNameClaim { get; set; }

        public bool IncludeFormVariables { get; set; }
    }
}
