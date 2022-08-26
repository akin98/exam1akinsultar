using Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL.Services.İnterface
{
    public interface IProductService
    {
        List<Products> GetAllProduct();
        Products CreateProduct(Products product);
        Products UpdateProduct(Products product);
        void DeleteProduct(int id);
    }
}
