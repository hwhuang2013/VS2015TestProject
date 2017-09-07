namespace MVCMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASMT_ERP_SaleOrder_01
    {
        [Key]
        [StringLength(20)]
        public string OrderNo { get; set; }

        public DateTime? OrderDate { get; set; }

        [StringLength(30)]
        public string CustID { get; set; }

        [StringLength(30)]
        public string CustID_Ship { get; set; }

        [StringLength(30)]
        public string AddressID { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string Address01 { get; set; }

        [StringLength(100)]
        public string Address02 { get; set; }

        [StringLength(100)]
        public string Address03 { get; set; }

        [StringLength(100)]
        public string Address04 { get; set; }

        [StringLength(100)]
        public string Address05 { get; set; }

        [StringLength(5)]
        public string ImExport { get; set; }

        [StringLength(50)]
        public string CustPO { get; set; }

        [StringLength(5)]
        public string DataSource { get; set; }

        [StringLength(20)]
        public string SalesEmpID { get; set; }

        [StringLength(20)]
        public string DeptID { get; set; }

        [StringLength(20)]
        public string TaxType { get; set; }

        [StringLength(20)]
        public string Currency { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExchangeRate { get; set; }

        [StringLength(20)]
        public string RMA { get; set; }

        [StringLength(20)]
        public string TradeTerms { get; set; }

        [StringLength(30)]
        public string TradeTermsDesc { get; set; }

        [StringLength(20)]
        public string PaymentTerms { get; set; }

        [StringLength(30)]
        public string PaymentTermsDesc { get; set; }

        [StringLength(20)]
        public string ShipFrom { get; set; }

        [StringLength(30)]
        public string ShipFromDesc { get; set; }

        [StringLength(20)]
        public string ShipTo { get; set; }

        [StringLength(30)]
        public string ShipToDesc { get; set; }

        [StringLength(20)]
        public string TrafficBy { get; set; }

        public DateTime? CustReqDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalAmount { get; set; }

        public DateTime? FirstConfirm { get; set; }

        [StringLength(20)]
        public string Site { get; set; }

        [StringLength(500)]
        public string ShipAddress { get; set; }

        [StringLength(5)]
        public string Status_ERP { get; set; }

        public DateTime? ExpShipDate { get; set; }

        [StringLength(50)]
        public string EndCust { get; set; }

        [StringLength(300)]
        public string Comment_Sales { get; set; }

        [StringLength(50)]
        public string ShipDest_Sales { get; set; }

        [StringLength(50)]
        public string ShipStock_Sales { get; set; }

        public DateTime? OrderDate_Cust { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(20)]
        public string UpdateEmpID { get; set; }

        [StringLength(20)]
        public string CreatedEmpID { get; set; }

        [StringLength(20)]
        public string UpdUser { get; set; }

        public DateTime? UpdTime { get; set; }
    }
}
