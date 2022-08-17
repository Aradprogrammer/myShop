using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Common.Roles;
using asp_store_bugeto.Domain.Entities.Commons;
using asp_store_bugeto.Domain.Entities.Emails;
using asp_store_bugeto.Domain.Entities.HomePage;
using asp_store_bugeto.Domain.Entities.Products;
using asp_store_bugeto.Domain.Entities.Users;
using asp_store_bugeto.Common.HomePageLocations;
using asp_store_bugeto.Domain.Entities.Carts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asp_store_bugeto.Domain.Entities.Finances;

namespace asp_store_bugeto.Persistence.Contexts
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
        public DbSet<SenderEmail> SenderEmails { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Temp> Temps { get; set; }
        public DbSet<SentEmail> SentEmails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<UserPopular> UsersPopulars { get; set; }
        public DbSet<PicAndLink> PicsAndLinks { get; set; }
        public DbSet<SliderCategory> SlidersCategory { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<RequestPay> RequestPays{ get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);


            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<SenderEmail>().HasIndex(x => x.AddressEmail).IsUnique();
            modelBuilder.Entity<Email>().HasIndex(x => x.Subject).IsUnique();


            ApplyQueryFilter(modelBuilder);


        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 10, Name = nameof(UserRoles.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 11, Name = nameof(UserRoles.Operator) });
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 12, Name = nameof(UserRoles.Customer) });
            modelBuilder.Entity<SenderEmail>().HasData(new SenderEmail() { Id = 1, AddressEmail = "test@email.com", Password = "1111", InsertTime = DateTime.Now });
            modelBuilder.Entity<Email>().HasData(new Email() { Id = 1, Subject = "بازیابی گذرواژه", Text = @"<a href= $Link >بازیابی گذرواژه</a>", Titel = "بازیابی گذرواژه", URL = "Authentication/resetpassword", SenderEmailId = 1 });
            modelBuilder.Entity<Email>().HasData(new Email() { Id = 2, Subject = "تایید ایمیل", Text = @"<a href= $Link >تایید ایمیل</a>", Titel = "تایید ایمیل", URL = "Authentication/verifyemail", SenderEmailId = 1 });
            modelBuilder.Entity<Temp>().HasData(new Temp() { InsertTime = DateTime.Now, Key = "Img_Path_Product", Value = $@"Images/ProductImage/", Id = 1 });
            modelBuilder.Entity<Temp>().HasData(new Temp() { InsertTime = DateTime.Now, Key = "Img_Path_HomePage", Value = $@"Images/HomePageImage/", Id = 2 });
            modelBuilder.Entity<SliderCategory>().HasData(new SliderCategory() { CountItem = 6, Id = 1, InsertTime = DateTime.Now, CategorySliderLocation = Enum.GetName(CategorySliderLocation.Slider1) });
            modelBuilder.Entity<SliderCategory>().HasData(new SliderCategory() { CountItem = 6, Id = 2, InsertTime = DateTime.Now, CategorySliderLocation = Enum.GetName(CategorySliderLocation.Slider2) });
            modelBuilder.Entity<SliderCategory>().HasData(new SliderCategory() { CountItem = 6, Id = 3, InsertTime = DateTime.Now, CategorySliderLocation = Enum.GetName(CategorySliderLocation.Slider3) });
            modelBuilder.Entity<SliderCategory>().HasData(new SliderCategory() { CountItem = 6, Id = 4, InsertTime = DateTime.Now, CategorySliderLocation = Enum.GetName(CategorySliderLocation.Slider4) });
        }
        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<SenderEmail>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<ProductFeatures>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<ProductImages>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<UserPopular>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<PicAndLink>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<SliderCategory>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<CartItem>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<Carts>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<RequestPay>().HasQueryFilter(p => !p.IsRemoved);
        }
    }
}