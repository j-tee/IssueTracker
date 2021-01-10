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
    public class IssueMap : IEntityTypeConfig<Issue>
    {
        public void Map(EntityTypeBuilder<Issue> builder)
        {
            builder.HasKey(a => a.IssueID);
            builder.Property(a => a.IssueID).HasDefaultValueSql("NEXT VALUE FOR DBSequence");
        }
    }
}
