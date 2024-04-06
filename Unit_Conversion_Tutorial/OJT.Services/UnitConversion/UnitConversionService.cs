using Entities.Product;
using OJT.DAO.Product;
using OJT.DAO.UnitConversion;
using OJT.Entities.UnitConversion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT.Services.UnitConversion
{
    public class UnitConversionService
    {
        private UnitConversionDao unitConversionDao = new UnitConversionDao();

        public DataTable GetWithName()
        {
            DataTable dt = unitConversionDao.GetWithName();
            return dt;
        }

        public DataTable GetAll()
        {
            DataTable dt = unitConversionDao.GetAll();
            return dt;
        }

        public DataTable getUnitConversion(int productId,int baseUnitId, int toUnitId)
        {
            DataTable dt = unitConversionDao.getUnitConversion(productId, baseUnitId, toUnitId);
            return dt;
        }
        public DataTable Get(int id)
        {
            DataTable dt = unitConversionDao.Get(id);
            return dt;
        }

        public float Multiplier(UnitConversionEntity unitConversionEntity)
        {
            DataTable dt = unitConversionDao.Multiplier(unitConversionEntity);
            float value = Convert.ToInt64( dt.Rows[0][0].ToString());
            return value;
        }

        public bool Insert(UnitConversionEntity unitConversionEntity)
        {
            return unitConversionDao.Insert(unitConversionEntity);
        }

        public bool Update(UnitConversionEntity unitConversionEntity, int tempProductID, int tempBaseUnitID, int tempToUnitID)
        {
            return unitConversionDao.Update(unitConversionEntity, tempProductID, tempBaseUnitID, tempToUnitID);
        }

        public bool Delete(int productId, int baseUnitId, int toUnitId)
        {
            return unitConversionDao.Delete(productId,baseUnitId,toUnitId);
        }
    }
}
