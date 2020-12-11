using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     public class TrCurJobOptNbcs : BaseEntity
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
          [Column("job_order_no")]
          public string JobOrderNo { get; set; }
          [Column("transaction_no")]
          public string TransactionNo { get; set; }
          [Column("data_transfer_complete_sign")]
          public string DataTransferCompleteSign { get; set; }
          [Column("err_sign")]
          public string ErrSign { get; set; }
          [Column("parent_job_order_no")]
          public string ParentJobOrderNo { get; set; }
          [Column("divide_sign")]
          public string DivideSign { get; set; }
          [Column("process_sign10")]
          public string ProcessSign10 { get; set; }
          [Column("customer_item")]
          public string CustomerItem { get; set; }
          [Column("main_stock_location")]
          public string MainStockLocation { get; set; }
          [Column("ship_to_stock_location")]
          public string ShipToStockLocation { get; set; }
          [Column("stock_account_no")]
          public string StockAccountNo { get; set; }
          [Column("curing_temperature1")]
          public int CuringTemperature1 { get; set; }
          [Column("curing_temperature2")]
          public int CuringTemperature2 { get; set; }
          [Column("curing_time_sec")]
          public double CuringTimeSec { get; set; }
          [Column("curing_pressure")]
          public double CuringPressure { get; set; }
          [Column("post_cure_time_hour")]
          public double PostCureTimeHour { get; set; }
          [Column("post_cure_temperature")]
          public int PostCureTemperature { get; set; }
          [Column("post_cure_condition")]
          public string PostCureCondition { get; set; }
          [Column("mold_substitute_sign")]
          public string MoldSubstituteSign { get; set; }
          [Column("mold_washing_method")]
          public string MoldWashingMethod { get; set; }
          [Column("mold_washing_frequency")]
          public double MoldWashingFrequency { get; set; }
          [Column("mold_washing_unit")]
          public string MoldWashingUnit { get; set; }
          [Column("additional_spec_code1")]
          public string AdditionalSpecCode1 { get; set; }
          [Column("additional_spec_name1")]
          public string AdditionalSpecName1 { get; set; }
          [Column("additional_spec_code2")]
          public string AdditionalSpecCode2 { get; set; }
          [Column("additional_spec_name2")]
          public string AdditionalSpecName2 { get; set; }
          [Column("additional_spec_code3")]
          public string AdditionalSpecCode3 { get; set; }
          [Column("additional_spec_name3")]
          public string AdditionalSpecName3 { get; set; }
          [Column("additional_spec_code4")]
          public string AdditionalSpecCode4 { get; set; }
          [Column("additional_spec_name4")]
          public string AdditionalSpecName4 { get; set; }
          [Column("additional_spec_code5")]
          public string AdditionalSpecCode5 { get; set; }
          [Column("additional_spec_name5")]
          public string AdditionalSpecName5 { get; set; }
          [Column("other_additional_spec1")]
          public string OtherAdditionalSpec1 { get; set; }
          [Column("other_additional_spec2")]
          public string OtherAdditionalSpec2 { get; set; }
          [Column("job_order")]
          public string JobOrder { get; set; }
          [Column("sales_request2")]
          public string SalesRequest2 { get; set; }
          [Column("sales_request3")]
          public string SalesRequest3 { get; set; }
          [Column("sales_request4")]
          public string SalesRequest4 { get; set; }
          [Column("update_request_sign")]
          public string UpdateRequestSign { get; set; }
          [Column("disposal_sign")]
          public string DisposalSign { get; set; }
          [Column("cement_coating_mark")]
          public string CementCoatingMark { get; set; }
          [Column("surface_treatment_line_group")]
          public string SurfaceTreatmentLineGroup { get; set; }
          [Column("cement_coating_line_group")]
          public string CementCoatingLineGroup { get; set; }
          [Column("box_specified")]
          public string BoxSpecified { get; set; }
          [Column("consolidate_co")]
          public string ConsolidateCo { get; set; }
          [Column("consolidate_co_line")]
          public string ConsolidateCoLine { get; set; }
          [Column("cosolid_co_qty")]
          public double CosolidCoQty { get; set; }
          [Column("finished_goods_weight")]
          public double FinishedGoodsWeight { get; set; }
          [Column("double_curing")]
          public string DoubleCuring { get; set; }
          [Column("internal_important_sign2")]
          public string InternalImportantSign2 { get; set; }
          [Column("internal_important_sign3")]
          public string InternalImportantSign3 { get; set; }
          [Column("schedule_memo1")]
          public string ScheduleMemo1 { get; set; }
          [Column("schedule_memo2")]
          public string ScheduleMemo2 { get; set; }
          [Column("schedule_memo3")]
          public string ScheduleMemo3 { get; set; }
          [Column("available_qty")]
          public double AvailableQty { get; set; }
     }
}
