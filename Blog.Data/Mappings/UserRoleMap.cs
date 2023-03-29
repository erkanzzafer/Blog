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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("22EAA855-41F8-455F-9A68-52400DAB2FF7"),
                RoleId=  Guid.Parse("82D3434D-6DA0-432B-989C-EEE036B650F2")
            }, new AppUserRole
            {
                UserId = Guid.Parse("4460F2F4-595E-42CF-A38E-899CD0D7105D"),
                RoleId = Guid.Parse("2116FA29-B71C-484D-823F-0E989EF46E37")

            });

        }
    }
}
