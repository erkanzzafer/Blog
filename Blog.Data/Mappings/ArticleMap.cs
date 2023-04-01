using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
	public class ArticleMap : IEntityTypeConfiguration<Article>
	{
		public void Configure(EntityTypeBuilder<Article> builder)
		{
			//builder.Property(x => x.Title).HasMaxLength(150);
			//builder.Property(x => x.Title).IsRequired(false); -> null geçilebilir

			builder.HasData(new Article
			{
				Id = Guid.NewGuid(),
				Title = "Asp.net Core Deneme Makalesi 1",
				Content = "Asp.net Core is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
				ViewCount = 15,
				CategoryId = Guid.Parse("94AAFAE7-CF2E-40C3-985D-C6755E6DDCDF"),
				ImageId= Guid.Parse("984F6E20-56AE-40BD-9983-B72E587117D9"),
				CreatedBy = "Admin test",
				CreatedDate = DateTime.Now,
				isDeleted = false,
				UserId= Guid.Parse("22EAA855-41F8-455F-9A68-52400DAB2FF7")
            }, 
			new Article
			{
				Id = Guid.NewGuid(),
				Title = "VS Deneme Makalesi 1",
				Content = "VS is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
				ViewCount = 15,
				CategoryId=Guid.Parse("12976718-DE50-4FC8-803B-DE0C49D8A3CF"),
				ImageId=Guid.Parse("D357A9A6-AC4B-4722-9E0F-C59B91A14547"),
				CreatedBy = "Admin test",
				CreatedDate = DateTime.Now,
				isDeleted = false,
				UserId= Guid.Parse("4460F2F4-595E-42CF-A38E-899CD0D7105D")
            }
			
			);

		}
	}
}
