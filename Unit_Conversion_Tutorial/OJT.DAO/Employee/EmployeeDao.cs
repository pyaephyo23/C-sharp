
using DAO.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OJT.Entities.Employee;

namespace OJT.DAO.Employee
{
    public class EmployeeDao
    {
        private DbConnection connection = new DbConnection();


        private string strSql = String.Empty;


        private DataTable resultDataTable = new DataTable();


        private int existCount;

        public DataTable GetTownshipWithName()
        {
            strSql = "SELECT ROW_NUMBER() OVER(ORDER BY TownshipId) AS RowNum, "+
                "TownshipId, Name From Township";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetTownship()
        {
            strSql = "SELECT * FROM Township ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Employees ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable GetWithName()
        {
            strSql = "SELECT ROW_NUMBER() OVER(ORDER BY e.EmployeeId) AS RowNum, " +
                    "e.EmployeeId, e.Name, e.PhNo, e.Email, e.Gender, e.EmployeeType, e.DateOfBirth, e.Address, " +
                    "t.Name AS TownshipName FROM Employees e JOIN Township t ON e.TownshipId = t.TownshipId ORDER BY e.EmployeeId ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM Employees " +
                      "WHERE  EmployeeId= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool InsertTownship(string name)
        {
            strSql = "INSERT INTO Township (Name) " +
                     "VALUES (@Name)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@Name",name),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Insert(EmployeeEntity employeeEntity)
        {
            strSql = "INSERT INTO Employees (Name, PhNo, Email, Gender, EmployeeType, DateOfBirth, Address, TownshipId) " +
                     "VALUES (@Name, @PhNo, @Email, @Gender, @EmployeeType, @DateOfBirth, @Address, @TownshipId)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@Name", employeeEntity.name),
                                        new SqlParameter("@PhNo", employeeEntity.phNo),
                                        new SqlParameter("@Email", employeeEntity.email),
                                        new SqlParameter("@Gender", employeeEntity.gender),
                                        new SqlParameter("@EmployeeType", employeeEntity.employeeType),
                                        new SqlParameter("@DateOfBirth", employeeEntity.dateOfBirth),
                                        new SqlParameter("@Address", employeeEntity.address),
                                        new SqlParameter("@TownshipId", employeeEntity.townshipId),

                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool Update(EmployeeEntity employeeEntity)
        {
            strSql = "UPDATE Employees SET Name = @Name, PhNo = @PhNo, Email = @Email, Gender = @Gender, EmployeeType = @EmployeeType, DateOfBirth = @DateOfBirth, Address = @Address, TownshipId = @TownshipId WHERE EmployeeId = @EmployeeId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@EmployeeId", employeeEntity.employeeId),
                                        new SqlParameter("@Name", employeeEntity.name),
                                        new SqlParameter("@PhNo", employeeEntity.phNo),
                                        new SqlParameter("@Email", employeeEntity.email),
                                        new SqlParameter("@Gender", employeeEntity.gender),
                                        new SqlParameter("@EmployeeType", employeeEntity.employeeType),
                                        new SqlParameter("@DateOfBirth", employeeEntity.dateOfBirth),
                                        new SqlParameter("@Address", employeeEntity.address),
                                        new SqlParameter("@TownshipId", employeeEntity.townshipId),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }
        public bool UpdateTownship(int id,string name)
        {
            strSql = "UPDATE Township SET Name = @Name WHERE TownshipId = @TownshipId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@TownshipId", id),
                                        new SqlParameter("@Name", name),
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Delete(int id)
        {
            strSql = "DELETE FROM Employees WHERE EmployeeId =@EmployeeId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@EmployeeId", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public bool DeleteTownship(int id)
        {
            strSql = "DELETE FROM Township WHERE TownshipId =@TownshipId";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@TownshipId", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
        public DataTable SearchInEmployee(int id)
        {
            strSql = "SELECT * FROM Employees " +
                      "WHERE  TownshipId= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
    }
}
