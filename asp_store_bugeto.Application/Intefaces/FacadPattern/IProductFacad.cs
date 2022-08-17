using asp_store_bugeto.Application.Services.Products.Commands.AddNewCategory;
using asp_store_bugeto.Application.Services.Products.Commands.AddNewProduct;
using asp_store_bugeto.Application.Services.Products.Commands.ChangeDisplaye;
using asp_store_bugeto.Application.Services.Products.Commands.EditCategory;
using asp_store_bugeto.Application.Services.Products.Commands.EditProduct;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveCategory;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveFeatur;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveImage;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveProduct;
using asp_store_bugeto.Application.Services.Products.Queries.GetAllCategories;
using asp_store_bugeto.Application.Services.Products.Queries.GetCategores;
using asp_store_bugeto.Application.Services.Products.Queries.GetProduct;
using asp_store_bugeto.Application.Services.Products.Queries.GetProductForAdmin;
using asp_store_bugeto.Application.Services.Products.Queries.GetProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_store_bugeto.Application.Intefaces.FacadPattern
{
    public interface IProductFacad
    {
        public AddNewCategoryService AddNewCategoryService { get; }
        public IGetCategoriesService GetCategoriesService { get; }
        public IEditCategoryService EditCategory { get; }
        public IRemoveCategoryService RemoveCategory { get; }
        public IAddNewProductService AddNewProduct { get; }
        public IGetAllCategoriesService GetAllCategories { get; }
        public IGetProductsService GetProducts { get; }
        public IGetProductsForAdminService GetProductsForAdmin { get; }
        public IGetProductForAdminService GetProductForAdmin { get; }
        public IChangeDisplayeService changeDisplaye { get; }
        public IRemoveFeaturService RemoveFeatur { get; }
        public IRemoveImageService RemoveImage { get; }
        public IRemoveProductService RemoveProduct { get; }
        public IEditProductService EditProduct { get; }
        public IGetProductService GetProduct { get; }
    }
}
