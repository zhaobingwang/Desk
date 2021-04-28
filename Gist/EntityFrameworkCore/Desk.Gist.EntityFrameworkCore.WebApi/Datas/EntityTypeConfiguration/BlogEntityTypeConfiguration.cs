using Desk.Gist.EntityFrameworkCore.WebApi.Datas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desk.Gist.EntityFrameworkCore.WebApi.Datas.EntityTypeConfiguration
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder
                .HasComment("Blogs managed on the website")
                .Property(b => b.Url).HasComment("Blog url")
                .IsRequired();
        }
    }
}
