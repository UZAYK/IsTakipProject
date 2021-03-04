using IsTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class BildirimlerMap : IEntityTypeConfiguration<Bildirim>
    {
        public void Configure(EntityTypeBuilder<Bildirim> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Aciklama).HasColumnType("ntext").IsRequired();
            builder.HasOne(I=> I.AppUser).WithMany(I=>I.Bildirimler).HasForeignKey(I=> I.AppUserId);
        }
    }
}
