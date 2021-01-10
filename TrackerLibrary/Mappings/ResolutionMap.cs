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
    public class ResolutionMap : IEntityTypeConfig<Resolution>
    {
        public void Map(EntityTypeBuilder<Resolution> builder)
        {
            builder.HasKey(a => a.ResolutionID);
            builder.Property(a => a.ResolutionID).HasDefaultValueSql("NEXT VALUE FOR DBSequence");
            builder.HasOne(a => a.Issue)
                .WithMany(a => a.Resolutions)
                .HasForeignKey(a => a.IssueID);
        }
    }
}
