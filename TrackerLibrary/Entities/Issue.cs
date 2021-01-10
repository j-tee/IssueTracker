using TrackerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URF.Core.EF.Trackable;

namespace TrackerLibrary.Entities
{
    public class Issue:Entity
    {
        public int IssueID { get; set; }       
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime IssueDate { get; set; }    

        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Resolution> Resolutions { get; set; }
        public virtual ICollection<Reproduction> Reproductions { get; set; }


    }
}
