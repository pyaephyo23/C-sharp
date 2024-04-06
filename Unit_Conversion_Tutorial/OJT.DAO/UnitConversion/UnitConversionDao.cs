using Entities.Product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Common;
using OJT.Entities.UnitConversion;

namespace OJT.DAO.UnitConversion
{
    public class UnitConversionDao
    {
        private DbConnection connection = new DbConnection();


        private string strSql = String.Empty;


        private DataTable resultDataTable = new DataTable();


        private int existCount;


        public DataTable GetWithName()
        {
            strSql = "SELECT p.Name AS ProductId,u1.Name AS BaseUnitId, uc.Multiplier, u2.Name AS ToUnitId"+
                   " FROM UnitConversion uc" +
                   " JOIN Products p ON uc.ProductId = p.ProductId"+
                   " JOIN Units u1 ON uc.BaseUnitId = u1.UnitId"+
                   " JOIN Units u2 ON uc.ToUnitId = u2.UnitId";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetAll()
        {
            strSql = "SELECT * FROM UnitConversion ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable getUnitConversion(int productId, int baseUnitId, int toUnitId)
        {
            strSql = "SELECT * FROM UnitConversion " +
                      "WHERE  ProductId= " + productId + "AND BaseUnitId= "+ baseUnitId+ "AND ToUnitId= " + toUnitId;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM UnitConversion " +
                      "WHERE  ProductId= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(UnitConversionEntity unitConversionEntity)
        {
            strSql = "INSERT INTO UnitConversion (ProductId ,BaseUnitId ,Multiplier,ToUnitId )" +
                     "VALUES(@ProductId , @BaseUnitId , @Multiplier ,@ToUnitId )";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@ProductId", unitConversionEntity.productId),
                                        new SqlParameter("@BaseUnitId", unitConversionEntity.baseUnitId),
                                        new SqlParameter("@Multiplier", unitConversionEntity.multiplier),
                                        new SqlParameter("@ToUnitId", unitConversionEntity.toUnitId),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Update(UnitConversionEntity unitConversionEntity, int tempProductID, int tempBaseUnitID ,int tempToUnitID)
        {
            strSql = "UPDATE UnitConversion SET ProductId = @ProductId , BaseUnitId = @BaseUnitId, Multiplier = @Multiplier, ToUnitId = @ToUnitId  WHERE ProductId = "+tempProductID+" AND BaseUnitId ="+tempBaseUnitID+" AND ToUnitId = "+tempToUnitID;

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@ProductId", unitConversionEntity.productId),
                                        new SqlParameter("@BaseUnitId", unitConversionEntity.baseUnitId),
                                        new SqlParameter("@Multiplier", unitConversionEntity.multiplier),
                                        new SqlParameter("@ToUnitId", unitConversionEntity.toUnitId),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Delete(int productId, int baseUnitId,int toUnitId)
        {
            strSql = "DELETE FROM UnitConversion  WHERE ProductId = @ProductId AND BaseUnitId = @BaseUnitId AND  ToUnitId = @ToUnitId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@ProductId", productId),
                                        new SqlParameter("@BaseUnitId", baseUnitId),
                                        new SqlParameter("@ToUnitId", toUnitId)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public DataTable Multiplier(UnitConversionEntity unitConversionEntity) 
        {
            strSql = "SELECT Multiplier FROM UnitConversion WHERE ProductId = "+ unitConversionEntity.productId + "AND BaseUnitId = "+unitConversionEntity.baseUnitId + "AND ToUnitId =" + unitConversionEntity.toUnitId;           
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

    }
}
