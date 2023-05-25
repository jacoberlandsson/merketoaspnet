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

            builder.Entity<ProductEntity>().HasData(
               new ProductEntity { ArticleNumber = "1010", ProductName = "AmazingSound123", Ingress ="Best headphones for rock music", Description="These headphones will make your life 12%b better if you like music", Image = "https://images.pexels.com/photos/1037992/pexels-photo-1037992.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", 
           Price = "1000", VendorName ="ABC Headphones"   },
               new ProductEntity
               {
                   ArticleNumber = "1020",
                   ProductName = "VeryGoodSound123",
                   Ingress = "Best headphones for pop music",
                   Description = "These headphones will make your life 18% better if you like music",
                   Image = "https://images.pexels.com/photos/1037999/pexels-photo-1037999.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                   Price = "2000",
                   VendorName = "ABC Headphones"
               },
                new ProductEntity
                {
                    ArticleNumber = "1030",
                    ProductName = "VeryAwesomeSound123",
                    Ingress = "Best headphones for alternative music",
                    Description = "Very very very very very good headphones",
                    Image = "https://images.pexels.com/photos/3761020/pexels-photo-3761020.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                    Price = "5000",
                    VendorName = "ABC Headphones"
                },
                 new ProductEntity
                 {
                     ArticleNumber = "1040",
                     ProductName = "GreatSound123",
                     Ingress = "Best headphones in 2021",
                     Description = "Extremely good and awesome and all around kinda great",
                     Image = "https://images.pexels.com/photos/3394660/pexels-photo-3394660.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                     Price = "3000",
                     VendorName = "ABC Headphones"
                 },
                   new ProductEntity
                   {
                       ArticleNumber = "1050",
                       ProductName = "OkaySound123",
                       Ingress = "Best of the average headphones in 2019",
                       Description = "Extremely okay and okay sound and all around kinda okay headphones",
                       Image = "https://images.pexels.com/photos/3394650/pexels-photo-3394650.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                       Price = "1000",
                       VendorName = "ABC Headphones"
                   },
                     new ProductEntity
                     {
                         ArticleNumber = "1060",
                         ProductName = "NotVeryGoodSound123",
                         Ingress = "Cheap and not very good",
                         Description = "If you do not like music but want to own a pair of headphones these are great",
                         Image = "https://images.pexels.com/photos/5081386/pexels-photo-5081386.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                         Price = "199",
                         VendorName = "ABC Headphones"
                     },
                      new ProductEntity
                      {
                          ArticleNumber = "1070",
                          ProductName = "VeryPro",
                          Ingress = "Top quality",
                          Description = "These are wow. Just wow.",
                          Image = "https://images.pexels.com/photos/3771842/pexels-photo-3771842.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                          Price = "10000",
                          VendorName = "ABC Headphones"
                      },
                       new ProductEntity
                       {
                           ArticleNumber = "1080",
                           ProductName = "KindaPro",
                           Ingress = "Almost Top quality",
                           Description = "These are kinda wow. Just kinda wow.",
                           Image = "https://images.pexels.com/photos/3587496/pexels-photo-3587496.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                           Price = "6000",
                           VendorName = "ABC Headphones"
                       },
                        new ProductEntity
                        {
                            ArticleNumber = "1090",
                            ProductName = "SemiPro",
                            Ingress = " Almost Top quality",
                            Description = "These are almost wow. Just almost wow.",
                            Image = "https://images.pexels.com/photos/2918997/pexels-photo-2918997.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            Price = "8000",
                            VendorName = "ABC Headphones"
                        },
                        new ProductEntity
                        {
                            ArticleNumber = "1100",
                            ProductName = "EverydayMusic",
                            Ingress = "Good Headphones",
                            Description = "Buy one of every color. Low price considering the good quality",
                            Image = "https://images.pexels.com/photos/819012/pexels-photo-819012.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            Price = "499",
                            VendorName = "ABC Headphones"
                        },
                        new ProductEntity
                        {
                            ArticleNumber = "1110",
                            ProductName = "Soundmaster",
                            Ingress = " Mastering sound through technology",
                            Description = "These work. You can listen to music with them",
                            Image = "https://images.pexels.com/photos/3587475/pexels-photo-3587475.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            Price = "20000",
                            VendorName = "ABC Headphones"
                        },
                        new ProductEntity
                        {
                            ArticleNumber = "1120",
                            ProductName = "Classics",
                            Ingress = "Headphones designed for classical music",
                            Description = "If you like classical music you should buy them.",
                            Image = "https://images.pexels.com/photos/3394663/pexels-photo-3394663.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2",
                            Price = "3000",
                            VendorName = "ABC Headphones"
                        }
           );

            builder.Entity<TagEntity>().HasData(
                new TagEntity { Id = 4, TagName = "New Headphones"},
                new TagEntity { Id = 5, TagName = "Featured headphones"},
                new TagEntity { Id = 6, TagName = "Popular headphones"}
            
            );

            builder.Entity<ProductTagEntity>().HasData(
                new ProductTagEntity { ArticleNumber = "1010", TagId = 4 },
                new ProductTagEntity { ArticleNumber = "1020", TagId = 4 },
                new ProductTagEntity { ArticleNumber = "1030", TagId = 4 },
                new ProductTagEntity { ArticleNumber = "1040", TagId = 4 },

                new ProductTagEntity { ArticleNumber = "1050", TagId = 5 },
                new ProductTagEntity { ArticleNumber = "1060", TagId = 5 },
                new ProductTagEntity { ArticleNumber = "1070", TagId = 5 },
                new ProductTagEntity { ArticleNumber = "1080", TagId = 5 },

                new ProductTagEntity { ArticleNumber = "1090", TagId = 6 },
                new ProductTagEntity { ArticleNumber = "1100", TagId = 6 },
                new ProductTagEntity { ArticleNumber = "1110", TagId = 6 },
                new ProductTagEntity { ArticleNumber = "1120", TagId = 6 }

            );


        }
    }
}
