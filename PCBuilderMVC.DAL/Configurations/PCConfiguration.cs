using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCBuilderMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilderMVC.DAL.Configurations
{
    public class PCConfiguration : IEntityTypeConfiguration<PC>
    {
        public void Configure(EntityTypeBuilder<PC> builder)
        {
            builder.ToTable("PC").HasKey(pc => pc.Id);
            builder.Property(pc => pc.Id).ValueGeneratedOnAdd();
            builder.Property(pc => pc.Name).IsRequired();
            builder.Property(pc => pc.CreatedDate).ValueGeneratedOnAdd();
            builder.Property(pc => pc.Cost).IsRequired();
            builder.Property(pc => pc._Images).HasColumnName("Images");
            builder.Property(pc => pc._CPU).HasColumnName("CPU").IsRequired();
            builder.Property(pc => pc._GPU).HasColumnName("GPU").IsRequired();
            builder.Property(pc => pc._MotherBoard).HasColumnName("MotherBoard").IsRequired();
            builder.Property(pc => pc._DRAM).HasColumnName("DRAM").IsRequired();
            builder.Property(pc => pc._PowerSupply).HasColumnName("PowerSupply").IsRequired();
            builder.Property(pc => pc._Case).HasColumnName("Case").IsRequired();
            builder.Property(pc => pc._PCColling).HasColumnName("PCColling").IsRequired();
            builder.Property(pc => pc._Storages).HasColumnName("Storages").IsRequired();
            builder.Property(pc => pc._Fans).HasColumnName("Fans");
        }
    }
}
