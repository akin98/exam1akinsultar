using Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Service.Interface
{
    public interface IProductBusinessService
    {
        List<Products> GetAllProduct();

        Products CreateProduct(Products product);
        void DeleteProduct(int id);
        Products UpdateProduct(Products product);
    }
}
