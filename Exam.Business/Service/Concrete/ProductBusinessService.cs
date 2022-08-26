using Exam.Business.Service.Interface;
using Exam.DAL.Services.Concarate;
using Exam.DAL.Services.İnterface;
using Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Service.Concrete
{
    public class ProductBusinessService : IProductBusinessService
    {
        private readonly IProductService _productService;
        public ProductBusinessService()
        {
            _productService = new ProductService();
        }
        public List<Products> GetAllProduct()
        {
            return _productService.GetAllProduct();
        }
        public Products CreateProduct(Products product)
        {
            return _productService.CreateProduct(product); 
        }
        public void DeleteProduct(int id)
        {
             _productService.DeleteProduct(id);
        }
        public Products UpdateProduct(Products product)
        {
            return _productService.UpdateProduct(product);
        }
    }
}
