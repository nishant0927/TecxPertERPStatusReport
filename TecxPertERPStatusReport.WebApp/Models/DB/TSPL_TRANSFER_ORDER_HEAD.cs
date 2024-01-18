//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecxPertERPStatusReport.WebApp.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSPL_TRANSFER_ORDER_HEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSPL_TRANSFER_ORDER_HEAD()
        {
            this.TSPL_DAIRYSALE_GATEPASS_MASTER = new HashSet<TSPL_DAIRYSALE_GATEPASS_MASTER>();
            this.TSPL_TRANSFER_GATE_OUT = new HashSet<TSPL_TRANSFER_GATE_OUT>();
            this.TSPL_TRANSFER_ORDER_DETAIL = new HashSet<TSPL_TRANSFER_ORDER_DETAIL>();
            this.TSPL_TRANSFER_RETURN = new HashSet<TSPL_TRANSFER_RETURN>();
        }
    
        public string Document_No { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string Transfer_Type { get; set; }
        public int Status { get; set; }
        public int On_Hold { get; set; }
        public string From_Location { get; set; }
        public string To_Location { get; set; }
        public string Vehicle_Code { get; set; }
        public string Vehicle_No { get; set; }
        public string Km_Reading { get; set; }
        public string Ref_No { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string Tax_Group { get; set; }
        public string TAX1 { get; set; }
        public Nullable<decimal> TAX1_Rate { get; set; }
        public Nullable<decimal> TAX1_Amt { get; set; }
        public Nullable<decimal> TAX1_Base_Amt { get; set; }
        public string TAX2 { get; set; }
        public Nullable<decimal> TAX2_Rate { get; set; }
        public Nullable<decimal> TAX2_Amt { get; set; }
        public Nullable<decimal> TAX2_Base_Amt { get; set; }
        public string TAX3 { get; set; }
        public Nullable<decimal> TAX3_Rate { get; set; }
        public Nullable<decimal> TAX3_Amt { get; set; }
        public Nullable<decimal> TAX3_Base_Amt { get; set; }
        public string TAX4 { get; set; }
        public Nullable<decimal> TAX4_Rate { get; set; }
        public Nullable<decimal> TAX4_Amt { get; set; }
        public Nullable<decimal> TAX4_Base_Amt { get; set; }
        public string TAX5 { get; set; }
        public Nullable<decimal> TAX5_Rate { get; set; }
        public Nullable<decimal> TAX5_Amt { get; set; }
        public Nullable<decimal> TAX5_Base_Amt { get; set; }
        public string TAX6 { get; set; }
        public Nullable<decimal> TAX6_Rate { get; set; }
        public Nullable<decimal> TAX6_Amt { get; set; }
        public Nullable<decimal> TAX6_Base_Amt { get; set; }
        public string TAX7 { get; set; }
        public Nullable<decimal> TAX7_Rate { get; set; }
        public Nullable<decimal> TAX7_Amt { get; set; }
        public Nullable<decimal> TAX7_Base_Amt { get; set; }
        public string TAX8 { get; set; }
        public Nullable<decimal> TAX8_Rate { get; set; }
        public Nullable<decimal> TAX8_Amt { get; set; }
        public Nullable<decimal> TAX8_Base_Amt { get; set; }
        public string TAX9 { get; set; }
        public Nullable<decimal> TAX9_Rate { get; set; }
        public Nullable<decimal> TAX9_Amt { get; set; }
        public Nullable<decimal> TAX9_Base_Amt { get; set; }
        public string TAX10 { get; set; }
        public Nullable<decimal> TAX10_Rate { get; set; }
        public Nullable<decimal> TAX10_Amt { get; set; }
        public Nullable<decimal> TAX10_Base_Amt { get; set; }
        public Nullable<decimal> Discount_Base { get; set; }
        public Nullable<decimal> Discount_Amt { get; set; }
        public Nullable<decimal> Amount_Less_Discount { get; set; }
        public Nullable<decimal> Total_Tax_Amt { get; set; }
        public Nullable<decimal> DOC_Total_Amt { get; set; }
        public string Comments { get; set; }
        public string Comp_Code { get; set; }
        public string Terms_Code { get; set; }
        public string Terms_Remark { get; set; }
        public string Due_Date { get; set; }
        public string Mode_Of_Transport { get; set; }
        public string Created_By { get; set; }
        public string Created_Date { get; set; }
        public string Modify_By { get; set; }
        public string Modify_Date { get; set; }
        public Nullable<System.DateTime> Posting_Date { get; set; }
        public string Delivery_date { get; set; }
        public string TransferOutNo { get; set; }
        public string Type { get; set; }
        public int Item_Type { get; set; }
        public int Tax_Calculation_Type { get; set; }
        public int Is_AgainstFormF { get; set; }
        public string CURRENCY_CODE { get; set; }
        public decimal ConvRate { get; set; }
        public Nullable<System.DateTime> ApplicableFrom { get; set; }
        public string Delivery_Duration { get; set; }
        public Nullable<decimal> Total_Amt_Less_Tax { get; set; }
        public int AutoTransfer { get; set; }
        public int Form_Received { get; set; }
        public int Form38 { get; set; }
        public string RMDA_Code { get; set; }
        public string WayBill_No { get; set; }
        public Nullable<System.DateTime> WayBill_Date { get; set; }
        public string GR_No { get; set; }
        public Nullable<System.DateTime> GR_Date { get; set; }
        public string Transport_Id { get; set; }
        public string Vehicle_Mannual_No { get; set; }
        public Nullable<double> Gross_Item_Wt { get; set; }
        public Nullable<double> Total_Item_Wt { get; set; }
        public Nullable<double> Vehicle_Capacity { get; set; }
        public Nullable<double> Vehicle_Charge { get; set; }
        public string Document_Type { get; set; }
        public int Item_Tax_Type { get; set; }
        public string Transporter_Name_Manual { get; set; }
        public string Is_Status_IN { get; set; }
        public string Price_Code { get; set; }
        public string GP_Item_Type { get; set; }
        public Nullable<double> Crate_IN { get; set; }
        public Nullable<double> jaali_IN { get; set; }
        public Nullable<double> Box_IN { get; set; }
        public Nullable<double> Crate_Out { get; set; }
        public Nullable<double> jaali_Out { get; set; }
        public Nullable<double> Box_Out { get; set; }
        public string Secondary_Code { get; set; }
        public string Freight_Type { get; set; }
        public double EmptyCharge { get; set; }
        public double FixedCharge { get; set; }
        public Nullable<decimal> RoundOffAmount { get; set; }
        public string EWayBillNo { get; set; }
        public Nullable<System.DateTime> EWayBillDate { get; set; }
        public string Electronic_Ref_No { get; set; }
        public int Is_Taxable { get; set; }
        public int Is_MandiTax { get; set; }
        public int For_Repair { get; set; }
        public int InternalTransfer { get; set; }
        public string GLVoucher_No { get; set; }
        public string Requisition_Id { get; set; }
        public string Loading_Advice_No { get; set; }
        public int IsJobWorkType { get; set; }
        public string TransferIndent_No { get; set; }
        public string EInvoice_Type { get; set; }
        public string IRN_No { get; set; }
        public string QR_Code { get; set; }
        public string Ack_No { get; set; }
        public Nullable<System.DateTime> Ack_Date { get; set; }
        public byte[] BarCode_Img { get; set; }
        public string EWayBillRemarks { get; set; }
        public Nullable<System.DateTime> EWayBillValidDate { get; set; }
        public int Freight_Distance { get; set; }
        public int ProdRequestTransfer { get; set; }
    
        public virtual TSPL_CURRENCY_MASTER TSPL_CURRENCY_MASTER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_DAIRYSALE_GATEPASS_MASTER> TSPL_DAIRYSALE_GATEPASS_MASTER { get; set; }
        public virtual TSPL_REQUISITION_HEAD TSPL_REQUISITION_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TRANSFER_GATE_OUT> TSPL_TRANSFER_GATE_OUT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TRANSFER_ORDER_DETAIL> TSPL_TRANSFER_ORDER_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSPL_TRANSFER_RETURN> TSPL_TRANSFER_RETURN { get; set; }
    }
}
