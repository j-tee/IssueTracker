using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URF.Core.EF.Trackable;

namespace TrackerLibrary.Entities
{
    public class Assignnee:Entity
    {
        public int AssignneeID { get; set; }
        public string UserID { get; set; }       
        
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
