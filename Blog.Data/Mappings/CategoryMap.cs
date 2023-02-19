using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(new Category
			{
				Id = Guid.Parse("94AAFAE7-CF2E-40C3-985D-C6755E6DDCDF"),
				Name = "Asp.net Core",
				CreatedDate = DateTime.Now,
				CreatedBy = "Admin Test",
				isDeleted = false
			}, new Category
			{

				Id = Guid.Parse("12976718-DE50-4FC8-803B-DE0C49D8A3CF"),
				Name = "Visual Studio",
				CreatedDate = DateTime.Now,
				CreatedBy = "Admin Test",
				isDeleted = false

			});
		}
	}
}
