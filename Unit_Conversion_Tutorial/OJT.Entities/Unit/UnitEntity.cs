namespace Entities.Product
{
    using System;

    public class UnitEntity
    {

        public int unitId { get; set; }


        public string name { get; set; }



        public UnitEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.unitId = 0;
            this.name = String.Empty;
        }
    }
}