using System;
using DAO.Common;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities.Product;

namespace OJT.DAO.Product
{
    public class ProductDao
    {
        private DbConnection connection = new DbConnection();

       
        private string strSql = String.Empty;

    
        private DataTable resultDataTable = new DataTable();

        
        private int existCount;

        public DataTable GetWithName()
        {
            strSql = "SELECT p.ProductId, p.Barcode, p.Name, u.Name AS BaseUnitId FROM Products p "+
                "JOIN Units u ON p.BaseUnitId = u.UnitId; ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Products ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetID(string name)
        {
            strSql = "SELECT * FROM Products " +
                      "WHERE  Name=" +name;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM Products " +
                      "WHERE  ProductId= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool SearchData(ProductEntity productEntity)
        {
            strSql = "SELECT * FROM Products " +
                      "WHERE Barcode=@Barcode AND Name=@Name AND BaseUnitId=@BaseUnitId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@Barcode", productEntity.barcode),
                                        new SqlParameter("@Name", productEntity.name),
                                        new SqlParameter("@BaseUnitId", productEntity.baseUnitId),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Insert(ProductEntity productEntity)
        {
            strSql = "INSERT INTO Products(Barcode,Name,BaseUnitId)" +
                     "VALUES(@Barcode, @Name, @BaseUnitId)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@Barcode", productEntity.barcode),
                                        new SqlParameter("@Name", productEntity.name),
                                        new SqlParameter("@BaseUnitId", productEntity.baseUnitId),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Update(ProductEntity productEntity)
        {
            strSql = "UPDATE Products SET Barcode = @Barcode , Name = @Name, BaseUnitId = @BaseUnitId WHERE ProductId = @ProductId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@ProductId", productEntity.productId),
                                        new SqlParameter("@Barcode", productEntity.barcode),
                                        new SqlParameter("@Name", productEntity.name),
                                        new SqlParameter("@BaseUnitId", productEntity.baseUnitId),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Delete(int id)
        {
            strSql = "DELETE FROM Products  WHERE ProductId =@ProductId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@ProductId", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

    }
}
