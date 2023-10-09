using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SFA.DAS.Payments.Common.Model.Core.Entities;

namespace SFA.DAS.Payments.Common.Application.Data.Configurations
{
    public class LatestSuccessfulJobModelConfiguration : IEntityTypeConfiguration<LatestSuccessfulJobModel>
    {
        public void Configure(EntityTypeBuilder<LatestSuccessfulJobModel> builder)
        {
            builder.HasKey(e => e.JobId);
            builder.ToTable("LatestSuccessfulJobs", "Payments2");
        }
    }
}