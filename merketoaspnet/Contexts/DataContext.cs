using merketoaspnet.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace merketoaspnet.Contexts
{
    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<ProductTagEntity> ProductTags { get; set; }    
        public DbSet<ContactFormEntity> Messages { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<UserAddressEntity> UserAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole {
                Id = "9b90fae1-57f4-481e-b2e8-25b1f547e67a",
                Name = "Administrator",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole
                {
                    Id = "c71aa991-0f56-4b59-b581-fdd57d958bf2",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                });

            var passwordHash = new PasswordHasher<UserEntity>();
            var adminEntity = new UserEntity
            {
                Id = "9ab0d2f8-a950-42fe-af29-456e8bebba1b",
                UserName = "administrator@merketo.com",
                NormalizedUserName = "ADMINISTRATOR@MERKETO.COM",
                Email = "administrator@merketo.com",
                NormalizedEmail = "ADMINISTRATOR@MERKETO.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
               
            };
            adminEntity.PasswordHash = passwordHash.HashPassword(adminEntity, "SnartSommar124!");

            builder.Entity<UserEntity>().HasData(adminEntity);


            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminEntity.Id,
                RoleId = "9b90fae1-57f4-481e-b2e8-25b1f547e67a",

            });
               
        }
    }
}
