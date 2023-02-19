using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Mappings
{
	public class ImageMap : IEntityTypeConfiguration<Image>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Image> builder)
		{
			builder.HasData(new Image
			{
				Id = Guid.Parse("984F6E20-56AE-40BD-9983-B72E587117D9"),
				FileName = "images/testimage",
				FileType = "jpg",
				CreatedBy = "Admin Test",
				isDeleted = false
			}, new Image
			{
				Id = Guid.Parse("D357A9A6-AC4B-4722-9E0F-C59B91A14547"),
				FileName = "images/testimage",
				FileType = "png",
				CreatedBy = "Admin Test",
				isDeleted = false
			});
		}
	}
}
