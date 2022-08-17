using asp_store_bugeto.Application.Intefaces.Contexts;
using asp_store_bugeto.Application.Intefaces.FacadPattern;
using asp_store_bugeto.Application.Services.Products.Commands.AddNewCategory;
using asp_store_bugeto.Application.Services.Products.Commands.AddNewProduct;
using asp_store_bugeto.Application.Services.Products.Commands.EditCategory;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveCategory;
using asp_store_bugeto.Application.Services.Products.Queries.GetAllCategories;
using asp_store_bugeto.Application.Services.Products.Queries.GetCategores;
using asp_store_bugeto.Application.Services.Products.Queries.GetProductForAdmin;
using asp_store_bugeto.Application.Services.Products.Queries.GetProducts;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using asp_store_bugeto.Application.Services.Products.Commands.ChangeDisplaye;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveFeatur;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveImage;
using asp_store_bugeto.Application.Services.Products.Commands.RemoveProduct;
using asp_store_bugeto.Application.Services.Products.Commands.EditProduct;
using asp_store_bugeto.Application.Services.Products.Queries.GetProduct;

namespace asp_store_bugeto.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        private readonly IMapper _mapper;
        public ProductFacad(IDataBaseContext context, IHostingEnvironment environment, IMapper mapper)
        {
            _context = context;
            _environment = environment;
            _mapper = mapper;
        }
        private AddNewCategoryService _addNewCategoryService;
        public AddNewCategoryService AddNewCategoryService
        {
            get
            {
                return _addNewCategoryService = _addNewCategoryService ?? new AddNewCategoryService(_context);
            }
        }
        private IGetCategoriesService _getCategoriesService;
        public IGetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCategoriesService = _getCategoriesService ?? new GetCategoriesService(_context);
            }
        }
        private IEditCategoryService _editCategory;
        public IEditCategoryService EditCategory
        {
            get
            {
                return _editCategory = _editCategory ?? new EditCategoryService(_context);
            }
        }
        private IRemoveCategoryService _removecategory;
        public IRemoveCategoryService RemoveCategory
        {
            get
            {
                return _removecategory = _removecategory ?? new RemoveCategoryService(_context);
            }
        }
        private IAddNewProductService _addNewProduct;
        public IAddNewProductService AddNewProduct
        {
            get
            {
                return _addNewProduct = _addNewProduct ?? new AddNewProductService(_context, _environment);
            }
        }
        private IGetAllCategoriesService _getAllCategoriesService;
        public IGetAllCategoriesService GetAllCategories
        {
            get
            {
                return _getAllCategoriesService = _getAllCategoriesService ?? new GetAllCategoriesService(_context);
            }
        }
        private IGetProductsService _getProductsService;
        public IGetProductsService GetProducts
        {
            get
            {
                return _getProductsService = _getProductsService ?? new GetProductsService(_context, _mapper);
            }
        }
        private IGetProductsForAdminService _getProductsForAdminService;
        public IGetProductsForAdminService GetProductsForAdmin
        {
            get
            {
                return _getProductsForAdminService = _getProductsForAdminService ?? new GetProductsForAdminService(_context, _mapper);
            }
        }
        private IGetProductForAdminService _getProductForAdminService;
        public IGetProductForAdminService GetProductForAdmin
        {
            get
            {
                return _getProductForAdminService = _getProductForAdminService ?? new GetProductForAdminService(_context, _mapper);
            }
        }
        private IChangeDisplayeService _changeDisplaye;
        public IChangeDisplayeService changeDisplaye
        {
            get
            {
                return _changeDisplaye = _changeDisplaye ?? new ChangeDisplayeService(_context);
            }
        }
        private IRemoveFeaturService _RemoveFeatur;
        public IRemoveFeaturService RemoveFeatur
        {
            get
            {
                return _RemoveFeatur = _RemoveFeatur ?? new RemoveFeaturService(_context);
            }
        }
        private IRemoveImageService _removeImage;
        public IRemoveImageService RemoveImage
        {
            get
            {
                return _removeImage = _removeImage ?? new RemoveImageService(_context);
            }
        }
        private IRemoveProductService _removeproduct;
        public IRemoveProductService RemoveProduct
        {
            get
            {
                return _removeproduct = _removeproduct ?? new RemoveProductService(_context);
            }
        }
        private IEditProductService _editProduct;
        public IEditProductService EditProduct
        {
            get
            {
                return _editProduct = _editProduct ?? new EditProductService(_context, _environment);
            }
        }
        private IGetProductService _getProduct;
        public IGetProductService GetProduct
        {
            get
            {
                return _getProduct = _getProduct ?? new GetProductService(_context);
            }
        }
    }
}
