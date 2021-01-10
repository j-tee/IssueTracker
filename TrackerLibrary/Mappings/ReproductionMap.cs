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
    public class ReproductionMap : IEntityTypeConfig<Reproduction>
    {
        public void Map(EntityTypeBuilder<Reproduction> builder)
        {
            builder.HasKey(a => a.ReproductionID);
            builder.Property(a => a.ReproductionID).HasDefaultValueSql("NEXT VALUE FOR DBSequence");
            builder.HasOne(a => a.Issue)
                .WithMany(a => a.Reproductions)
                .HasForeignKey(a => a.IssueID);
        }
    }
}
