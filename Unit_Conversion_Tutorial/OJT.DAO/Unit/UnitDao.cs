using Entities.Product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Common;

namespace OJT.DAO.Unit
{
    public class UnitDao
    {
        private DbConnection connection = new DbConnection();


        private string strSql = String.Empty;
        private string strSqlProduct = String.Empty;
        private string strSqlUnitConversion = String.Empty;

        private DataTable resultDataTable = new DataTable();


        private int existCount;


        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Units ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM Units " +
                      "WHERE  UnitId= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(UnitEntity unitEntity)
        {
            strSql = "INSERT INTO Units(Name)" +
                     "VALUES(@Name)";

            SqlParameter[] sqlParam = {                                    
                                        new SqlParameter("@Name", unitEntity.name),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Update(UnitEntity unitEntity)
        {
            strSql = "UPDATE Units SET Name = @Name WHERE UnitId = @UnitId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@UnitId", unitEntity.unitId),
                                        new SqlParameter("@Name", unitEntity.name),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Delete(int id)
        {
           
            strSqlUnitConversion = "DELETE FROM UnitConversion  WHERE BaseUnitId =@UnitId OR ToUnitId =@UnitId";
            strSql = "DELETE FROM Units  WHERE UnitId =@UnitId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@UnitId", id)
                                      };
           
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSqlUnitConversion, sqlParam);
            success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

    }
}
