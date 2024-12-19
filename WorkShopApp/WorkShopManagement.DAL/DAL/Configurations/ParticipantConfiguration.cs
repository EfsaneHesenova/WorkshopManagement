using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.DAL.DAL.Configurations
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
           builder.HasOne(p=> p.Workshop)
                .WithMany(p=> p.Participants)
                .HasForeignKey(p=> p.WorkshopId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
