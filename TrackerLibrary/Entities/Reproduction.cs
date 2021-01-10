using TrackerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URF.Core.EF.Trackable;

namespace TrackerLibrary.Entities
{
    public class Reproduction:Entity
    {
        public int ReproductionID { get; set; }
        public int IssueID { get; set; }
        public string Details { get; set; }

        public virtual Issue Issue { get; set; }
    }
}
