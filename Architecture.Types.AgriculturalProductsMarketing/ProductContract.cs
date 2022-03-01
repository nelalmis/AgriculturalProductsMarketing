namespace Architecture.Types.AgriculturalProductsMarketing
{
    using Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Serializable]
    [Table("Product")]
    public partial class ProductContract:ContractBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductContract()
        {
            Order_Detail = new HashSet<Order_DetailContract>();
        }
        [Key]
        public int ProductId { get; set; }

        public int? SupplierProductId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? SupplierId { get; set; }

        public int? CategoryId { get; set; }

        public int? SupplierCategoryId { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Column("Unit Price", TypeName = "money")]
        public decimal? Unit_Price { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool? Discontinued { get; set; }

        [StringLength(500)]
        public string ImageLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_DetailContract> Order_Detail { get; set; }
    }
}
