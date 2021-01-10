using IssueTracker.Data.Configurations;
using TrackerLibrary.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerLibrary.Mappings
{
    public class AssignmentMap : IEntityTypeConfig<Assignment>
    {
        public void Map(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(a => new { a.AssignneeID,a.IssueID });
            builder.HasOne(a => a.Assignnee)
                .WithMany(a => a.Assignments)
                .HasForeignKey(a => a.AssignneeID);

            builder.HasOne(a => a.Issue)
                .WithMany(a => a.Assignments)
                .HasForeignKey(a => a.IssueID);
        }
    }
}
