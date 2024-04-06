using Entities.Product;
using OJT.DAO.Product;
using OJT.DAO.Unit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT.Services.Unit
{
    public class UnitService
    {
        private UnitDao unitDao = new UnitDao();

        public DataTable GetAll()
        {
            DataTable dt = unitDao.GetAll();
            return dt;
        }

        public DataTable Get(int id)
        {
            DataTable dt = unitDao.Get(id);
            return dt;
        }

        public bool Insert(UnitEntity unitEntity)
        {
            return unitDao.Insert(unitEntity);
        }

        public bool Update(UnitEntity unitEntity)
        {
            return unitDao.Update(unitEntity);
        }

        public bool Delete(int id)
        {
            return unitDao.Delete(id);
        }
    }
}
