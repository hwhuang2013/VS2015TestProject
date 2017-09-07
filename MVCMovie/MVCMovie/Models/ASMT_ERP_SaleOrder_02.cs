namespace MVCMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASMT_ERP_SaleOrder_02
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string OrderNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderItem { get; set; }

        [StringLength(50)]
        public string ProdID01 { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice_Discount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AmountTax { get; set; }

        public DateTime? CustReqDate_Detail { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QtyShip { get; set; }

        [StringLength(1)]
        public string ShipStatus { get; set; }

        public int? CustPOItem { get; set; }

        [StringLength(100)]
        public string CustPN { get; set; }

        [StringLength(300)]
        public string CustPN_Comment { get; set; }

        public DateTime? CustReqDate_Sales { get; set; }

        public DateTime? ExpShipDate_Sales { get; set; }

        [StringLength(50)]
        public string EndCust_Detail { get; set; }

        [StringLength(1)]
        public string IsUpd_Discount_Manual { get; set; }

        [StringLength(20)]
        public string UpdUser { get; set; }

        public DateTime? UpdTime { get; set; }
    }
}
