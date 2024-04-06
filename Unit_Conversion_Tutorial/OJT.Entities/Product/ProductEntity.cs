namespace Entities.Product
{
    using System;

    public class ProductEntity
    {
     
        public int productId { get; set; }

        public string barcode { get; set; }

        public string name { get; set; }
  
        public int baseUnitId { get; set; }

    
        public ProductEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.productId = 0;
            this.barcode = String.Empty;
            this.name = String.Empty;
            this.baseUnitId = 0;
        }
    }
}