

namespace OJT.Entities.UnitConversion
{

    using System;

    public class UnitConversionEntity
    {

        public int productId { get; set; }

        public int baseUnitId { get; set; }

        public decimal multiplier { get; set; }

        public int toUnitId { get; set; }


        public UnitConversionEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.productId = 0;
            this.baseUnitId = 0;
            this.multiplier = 0;
            this.baseUnitId = 0;
        }
    }
}
