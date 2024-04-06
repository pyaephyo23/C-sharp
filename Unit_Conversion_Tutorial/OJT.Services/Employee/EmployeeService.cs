using OJT.DAO.Employee;
using OJT.Entities.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace OJT.Services.Employee
{
    public class EmployeeService
    {
        private EmployeeDao employeeDao = new EmployeeDao();

        public DataTable GetWithName()
        {
            DataTable dt = employeeDao.GetWithName();
            return dt;
        }
        public DataTable GetAll()
        {
            DataTable dt = employeeDao.GetAll();
            return dt;
        }
        public DataTable GetTownshipWithName()
        {
            DataTable dt = employeeDao.GetTownshipWithName();
            return dt;
        }

        public DataTable GetTownship()
        {
            DataTable dt = employeeDao.GetTownship();
            return dt;
        }
        public DataTable Get(int id)
        {
            DataTable dt = employeeDao.Get(id);
            return dt;
        }
        public bool Insert(EmployeeEntity employeeEntity)
        {
            return employeeDao.Insert(employeeEntity);
        }

        public bool InsertTownship(string name)
        {
            return employeeDao.InsertTownship(name);
        }

        public bool Update(EmployeeEntity employeeEntity)
        {
            return employeeDao.Update(employeeEntity);
        }

        public bool UpdateTownship(int id, string name)
        {
            return employeeDao.UpdateTownship(id,name);
        }

        public bool Delete(int id)
        {
            return employeeDao.Delete(id);
        }

        public bool DeleteTownship(int id)
        {
            return employeeDao.DeleteTownship(id);
        }

        public DataTable SearchInEmployee(int id)
        {
            return employeeDao.SearchInEmployee(id);
        }
    }
}
