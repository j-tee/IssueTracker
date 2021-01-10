using TrackerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URF.Core.EF.Trackable;

namespace TrackerLibrary.Entities
{
    public class Assignment:Entity
    {
        public int AssignneeID { get; set; }
        public int IssueID { get; set; }  
        public DateTime DateAssigned { get; set; }

        public virtual Assignnee Assignnee { get; set; }
        public virtual Issue Issue { get; set; }
    }
}
