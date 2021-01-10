using IssueTracker.Data.Configurations;
using TrackerLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerLibrary.Mappings
{
    public class AssignneeMap : IEntityTypeConfig<Assignnee>
    {
        public void Map(EntityTypeBuilder<Assignnee> builder)
        {
            builder.HasKey(a => a.AssignneeID);
            builder.Property(a => a.AssignneeID).HasDefaultValueSql("NEXT VALUE FOR DBSequence");
        }
    }
}
