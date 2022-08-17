using asp_store_bugeto.Domain.Entities.Carts;
using asp_store_bugeto.Domain.Entities.Commons;
using asp_store_bugeto.Domain.Entities.Emails;
using asp_store_bugeto.Domain.Entities.Finances;
using asp_store_bugeto.Domain.Entities.HomePage;
using asp_store_bugeto.Domain.Entities.Products;
using asp_store_bugeto.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Intefaces.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserInRole> UserInRoles { get; set; }
        DbSet<SenderEmail> SenderEmails { get; set; }
        DbSet<Email> Emails { get; set; }
        DbSet<Temp> Temps { get; set; }
        DbSet<SentEmail> SentEmails { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductFeatures> ProductFeatures { get; set; }
        DbSet<ProductImages> ProductImages { get; set; }
        DbSet<UserPopular> UsersPopulars { get; set; }
        DbSet<PicAndLink> PicsAndLinks { get; set; }
        DbSet<SliderCategory> SlidersCategory { get; set; }
        DbSet<Carts> Carts { get; set; }
        DbSet<CartItem> CartItems { get; set; }
        DbSet<RequestPay> RequestPays{ get; set; }
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
