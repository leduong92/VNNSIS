using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     public class TrLblInfoNbcs : BaseEntity
     {
          [Column("record_status")]
          public string RecordStatus { get; set; }
          [Column("entry_date")]
          public int EntryDate { get; set; }
          [Column("entry_time")]
          public int EntryTime { get; set; }
          [Column("update_date")]
          public int UpdateDate { get; set; }
          [Column("update_time")]
          public int UpdateTime { get; set; }
          [Column("entry_terminal_id")]
          public string EntryTerminalId { get; set; }
          [Column("program_id")]
          public string ProgramId { get; set; }
          [Column("update_user_code")]
          public string UpdateUserCode { get; set; }
          [Column("company_code")]
          public string CompanyCode { get; set; }
          [Column("plant_code")]
          public string PlantCode { get; set; }
          [Column("mps_no")]
          public string MpsNo { get; set; }
          [Column("data_transfer_complete_sign")]
          public string DataTransferCompleteSign { get; set; }
          [Column("err_sign")]
          public string ErrSign { get; set; }
          [Column("job_order_no")]
          public string JobOrderNo { get; set; }
          [Column("seq_no")]
          public string SeqNo { get; set; }
          [Column("ship_to_address1")]
          public string ShipToAddress1 { get; set; }
          [Column("ship_to_address2")]
          public string ShipToAddress2 { get; set; }
          [Column("ship_to_company_name1")]
          public string ShipToCompanyName1 { get; set; }
          [Column("ship_to_company_name2")]
          public string ShipToCompanyName2 { get; set; }
          [Column("line_group")]
          public string LineGroup { get; set; }
          [Column("item_sign")]
          public string ItemSign { get; set; }
          [Column("main_stock_location")]
          public string MainStockLocation { get; set; }
          [Column("ship_to_stock_location")]
          public string ShipToStockLocation { get; set; }
          [Column("purchase_order_no")]
          public string PurchaseOrderNo { get; set; }
          [Column("made_in_japan")]
          public string MadeInJapan { get; set; }
          [Column("customer_item")]
          public string CustomerItem { get; set; }
          [Column("customer_code")]
          public string CustomerCode { get; set; }
          [Column("finished_goods_code1")]
          public string FinishedGoodsCode1 { get; set; }
          [Column("finished_goods_code2")]
          public string FinishedGoodsCode2 { get; set; }
          [Column("special_specification_sign")]
          public string SpecialSpecificationSign { get; set; }
          [Column("large_letter_type")]
          public string LargeLetterType { get; set; }
          [Column("box_label_type")]
          public string BoxLabelType { get; set; }
          [Column("ship_label")]
          public string ShipLabel { get; set; }
          [Column("box_qty")]
          public double BoxQty { get; set; }
          [Column("stock_account_no")]
          public string StockAccountNo { get; set; }
          [Column("lot_no")]
          public string LotNo { get; set; }
          [Column("location_no")]
          public string LocationNo { get; set; }
          [Column("customer_order_no")]
          public string CustomerOrderNo { get; set; }
          [Column("shipping_control_code")]
          public string ShippingControlCode { get; set; }
          [Column("print_type")]
          public string PrintType { get; set; }
          [Column("address3")]
          public string Address3 { get; set; }
          [Column("address4")]
          public string Address4 { get; set; }
          [Column("delivery_place")]
          public string DeliveryPlace { get; set; }
          [Column("denominator")]
          public string Denominator { get; set; }
          [Column("filler")]
          public string Filler { get; set; }
          [Column("update_request_sign")]
          public string UpdateRequestSign { get; set; }
          [Column("customer_name")]
          public string CustomerName { get; set; }
          [Column("pack_qty")]
          public double PackQty { get; set; }
          [Column("packing_label_type")]
          public string PackingLabelType { get; set; }
          [Column("jis_sign")]
          public string JisSign { get; set; }
          [Column("cust_user_code")]
          public string CustUserCode { get; set; }
          [Column("cust_user_item")]
          public string CustUserItem { get; set; }
          [Column("cust_user_insp_place")]
          public string CustUserInspPlace { get; set; }
          [Column("cust_user_loc_no")]
          public string CustUserLocNo { get; set; }
          [Column("cust_user_main_stk_loc")]
          public string CustUserMainStkLoc { get; set; }
          [Column("cust_user_stk_acc_no")]
          public string CustUserStkAccNo { get; set; }
          [Column("packing_label_type_sign")]
          public string PackingLabelTypeSign { get; set; }
          [Column("box_label_print_type")]
          public string BoxLabelPrintType { get; set; }
          [Column("additional_spec_code1")]
          public string AdditionalSpecCode1 { get; set; }
          [Column("cocom_sign")]
          public string CocomSign { get; set; }
          [Column("material_mark1")]
          public string MaterialMark1 { get; set; }
          [Column("rohs_sign")]
          public string RohsSign { get; set; }
          [Column("paper_verification_mark")]
          public string PaperVerificationMark { get; set; }
          [Column("food_app")]
          public string FoodApp { get; set; }
          [Column("trace_no")]
          public string TraceNo { get; set; }
          [Column("packing_label_form_no")]
          public string PackingLabelFormNo { get; set; }
          [Column("box_label_form_no")]
          public string BoxLabelFormNo { get; set; }
          [Column("qr_data")]
          public string QrData { get; set; }
          [Column("customer_name_1")]
          public string CustomerName1 { get; set; }
          [Column("customer_name_2")]
          public string CustomerName2 { get; set; }
          [Column("transaction_no")]
          public string TransactionNo { get; set; }
          [Column("finished_goods_code")]
          public string FinishedGoodsCode { get; set; }
          [Column("notes1")]
          public string Notes1 { get; set; }
          [Column("unit_of_measure")]
          public string UnitOfMeasure { get; set; }
          [Column("disposal_sign")]
          public string DisposalSign { get; set; }
          [Column("comment_01")]
          public string Comment01 { get; set; }
          [Column("comment_02")]
          public string Comment02 { get; set; }
          [Column("comment_03")]
          public string Comment03 { get; set; }
          [Column("comment_04")]
          public string Comment04 { get; set; }
          [Column("comment_05")]
          public string Comment05 { get; set; }
          [Column("stock_data_type")]
          public string StockDataType { get; set; }
          [Column("customer_name_for_label")]
          public string CustomerNameForLabel { get; set; }
          [Column("customer_item_for_label")]
          public string CustomerItemForLabel { get; set; }
          [Column("cust_print_req_for_label")]
          public string CustPrintReqForLabel { get; set; }
          [Column("itemd_description_for_label")]
          public string ItemdDescriptionForLabel { get; set; }
     }
}
