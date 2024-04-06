using Entities.Product;
using OJT.DAO.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace OJT.Services.product
{
    public class ProductService
    {
        private ProductDao productDao = new ProductDao();
        public DataTable GetWithName()
        {
            DataTable dt = productDao.GetWithName();
            return dt;
        }
        public DataTable GetAll()
        {
            DataTable dt = productDao.GetAll();
            return dt;
        }

        public DataTable Get(int id)
        {
            DataTable dt = productDao.Get(id);
            return dt;
        }
        public DataTable GetID(string name)
        {
           DataTable dt = productDao.GetID(name);
            return dt;
           
        }

        public bool SearchData(ProductEntity productEntity)
        {
            return productDao.SearchData(productEntity);
        }
        public bool Insert(ProductEntity productEntity)
        {
            return productDao.Insert(productEntity);
        }

        public bool Update(ProductEntity productEntity)
        {
            return productDao.Update(productEntity);
        }

        public bool Delete(int id)
        {
            return productDao.Delete(id);
        }
    }
}
