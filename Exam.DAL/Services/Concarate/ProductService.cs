using Exam.DAL.Services.İnterface;
using Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DAL.Services.Concarate
{
    public class ProductService : IProductService
    {
        ExamDbContext context = new ExamDbContext();
        public List<Products> GetAllProduct()
        {
            return context.Products.ToList();
        }
        public Products CreateProduct(Products product)
        {
            product.CreateDate = DateTime.Now.ToString();
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }
        public void DeleteProduct(int id)
        {
            var silinecek = context.Products.Find(id);
            context.Products.Remove(silinecek);
            context.SaveChanges();
        }
        public Products UpdateProduct(Products product)
        {
            //var model = context.Products.FirstOrDefault(a => a.Id == product.Id);
            context.Products.Update(product);
            context.SaveChanges();
            return product;
        }
    }
}
