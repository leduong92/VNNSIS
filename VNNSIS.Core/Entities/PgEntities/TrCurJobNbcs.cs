using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("tr_cur_job_nbcs")]
     public class TrCurJobNbcs : BaseEntity
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
          [Column("data_transfer_complete_sign")]
          public string DataTransferCompleteSign { get; set; }
          [Column("err_sign")]
          public string ErrSign { get; set; }
          [Column("parent_job_order_no")]
          public string ParentJobOrderNo { get; set; }
          [Column("divide_sign")]
          public string DivideSign { get; set; }
          [Column("manufactured_curing")]
          public string ManufacturedCuring { get; set; }
          [Column("list_type_rubber")]
          public string ListTypeRubber { get; set; }
          [Column("list_type_parts")]
          public string ListTypeParts { get; set; }
          [Column("purchase_order")]
          public string PurchaseOrder { get; set; }
          [Column("process_sign7")]
          public string ProcessSign7 { get; set; }
          [Column("process_sign8")]
          public string ProcessSign8 { get; set; }
          [Column("process_sign9")]
          public string ProcessSign9 { get; set; }
          [Column("process_sign10")]
          public string ProcessSign10 { get; set; }
          [Column("urgent_schedule_sign")]
          public string UrgentScheduleSign { get; set; }
          [Column("machine_set_up_sign")]
          public string MachineSetUpSign { get; set; }
          [Column("final_sign")]
          public string FinalSign { get; set; }
          [Column("jis_sign")]
          public string JisSign { get; set; }
          [Column("set_item_sign")]
          public string SetItemSign { get; set; }
          [Column("finished_goods_code")]
          public string FinishedGoodsCode { get; set; }
          [Column("customer_code")]
          public string CustomerCode { get; set; }
          [Column("limitation_item_sign")]
          public string LimitationItemSign { get; set; }
          [Column("mp_code")]
          public string MpCode { get; set; }
          [Column("enterprise_code")]
          public string EnterpriseCode { get; set; }
          [Column("line_group")]
          public string LineGroup { get; set; }
          [Column("line_no")]
          public string LineNo { get; set; }
          [Column("press_no")]
          public string PressNo { get; set; }
          [Column("data_no")]
          public string DataNo { get; set; }
          [Column("mps_no")]
          public string MpsNo { get; set; }
          [Column("co_qty")]
          public double CoQty { get; set; }
          [Column("co_due_date")]
          public int CoDueDate { get; set; }
          [Column("customer_order_no")]
          public string CustomerOrderNo { get; set; }
          [Column("set_item_co_line_no")]
          public string SetItemCoLineNo { get; set; }
          [Column("round_unit")]
          public string RoundUnit { get; set; }
          [Column("packing_type")]
          public string PackingType { get; set; }
          [Column("packing_package_type")]
          public string PackingPackageType { get; set; }
          [Column("packing_label_type")]
          public string PackingLabelType { get; set; }
          [Column("packing_label_type_sign")]
          public string PackingLabelTypeSign { get; set; }
          [Column("pack_qty")]
          public double PackQty { get; set; }
          [Column("box_label_type")]
          public string BoxLabelType { get; set; }
          [Column("box_label_print_type")]
          public string BoxLabelPrintType { get; set; }
          [Column("box_qty")]
          public double BoxQty { get; set; }
          [Column("vendor_code")]
          public string VendorCode { get; set; }
          [Column("external_fabrication_po_no")]
          public string ExternalFabricationPoNo { get; set; }
          [Column("nickname_no")]
          public string NicknameNo { get; set; }
          [Column("material_mark1")]
          public string MaterialMark1 { get; set; }
          [Column("compound_mark1")]
          public string CompoundMark1 { get; set; }
          [Column("material_mark2")]
          public string MaterialMark2 { get; set; }
          [Column("compound_mark2")]
          public string CompoundMark2 { get; set; }
          [Column("metal_case_material_code")]
          public string MetalCaseMaterialCode { get; set; }
          [Column("spring_material_code")]
          public string SpringMaterialCode { get; set; }
          [Column("other_material_type")]
          public string OtherMaterialType { get; set; }
          [Column("partial_shipment_sign")]
          public string PartialShipmentSign { get; set; }
          [Column("delivery_type")]
          public string DeliveryType { get; set; }
          [Column("internal_order_from_plant_code")]
          public string InternalOrderFromPlantCode { get; set; }
          [Column("cost_accounting_division")]
          public string CostAccountingDivision { get; set; }
          [Column("internal_order_from_sector")]
          public string InternalOrderFromSector { get; set; }
          [Column("stock_item_sign")]
          public string StockItemSign { get; set; }
          [Column("cavity_qty")]
          public int CavityQty { get; set; }
          [Column("mold_plate_qty")]
          public int MoldPlateQty { get; set; }
          [Column("rotation")]
          public int Rotation { get; set; }
          [Column("curing_qty")]
          public double CuringQty { get; set; }
          [Column("good_item_qty")]
          public double GoodItemQty { get; set; }
          [Column("carry_over_good_item_qty")]
          public double CarryOverGoodItemQty { get; set; }
          [Column("capability_sign")]
          public string CapabilitySign { get; set; }
          [Column("curing_date")]
          public int CuringDate { get; set; }
          [Column("order_type")]
          public string OrderType { get; set; }
          [Column("box_label_qty")]
          public int BoxLabelQty { get; set; }
          [Column("stock_in_order1")]
          public double StockInOrder1 { get; set; }
          [Column("inspection_card_print_qty")]
          public int InspectionCardPrintQty { get; set; }
          [Column("latest_label_sign")]
          public string LatestLabelSign { get; set; }
          [Column("latest_stock_in_order")]
          public double LatestStockInOrder { get; set; }
          [Column("re_schedule_sign")]
          public string ReScheduleSign { get; set; }
          [Column("parts_purchase_order_sign")]
          public string PartsPurchaseOrderSign { get; set; }
          [Column("planned_stock_in_date")]
          public int PlannedStockInDate { get; set; }
          [Column("stock_in_order_qty")]
          public double StockInOrderQty { get; set; }
          [Column("special_specification_sign")]
          public string SpecialSpecificationSign { get; set; }
          [Column("internal_important_sign1")]
          public string InternalImportantSign1 { get; set; }
          [Column("first_mass_production_route")]
          public string FirstMassProductionRoute { get; set; }
          [Column("coating_material_type")]
          public string CoatingMaterialType { get; set; }
          [Column("mold")]
          public string Mold { get; set; }
          [Column("pre_process_days")]
          public double PreProcessDays { get; set; }
          [Column("post_process_day")]
          public double PostProcessDay { get; set; }
          [Column("mold_divide_sign")]
          public string MoldDivideSign { get; set; }
          [Column("special_process_code")]
          public string SpecialProcessCode { get; set; }
          [Column("job_tag_divide_qty")]
          public int JobTagDivideQty { get; set; }
          [Column("extensive_job_scheduling_job_tag_qty")]
          public int ExtensiveJobSchedulingJobTagQty { get; set; }
          [Column("good_item_control_sign")]
          public string GoodItemControlSign { get; set; }
          [Column("press_no_2")]
          public string PressNo2 { get; set; }
          [Column("press_no_3")]
          public string PressNo3 { get; set; }
          [Column("press_no_4")]
          public string PressNo4 { get; set; }
          [Column("press_no_5")]
          public string PressNo5 { get; set; }
          [Column("press_no_6")]
          public string PressNo6 { get; set; }
          [Column("press_no_7")]
          public string PressNo7 { get; set; }
          [Column("press_no_8")]
          public string PressNo8 { get; set; }
          [Column("lot_no")]
          public string LotNo { get; set; }
          [Column("paper_verification_mark")]
          public string PaperVerificationMark { get; set; }
          [Column("paper_verification_no")]
          public int PaperVerificationNo { get; set; }
          [Column("update_request_sign")]
          public string UpdateRequestSign { get; set; }
          [Column("disposal_sign")]
          public string DisposalSign { get; set; }
          [Column("tag_no")]
          public string TagNo { get; set; }
          [Column("total_tag_no")]
          public string TotalTagNo { get; set; }
          [Column("stock_data_type")]
          public string StockDataType { get; set; }
          [Column("transaction_no")]
          public string TransactionNo { get; set; }
          [Column("entry_no")]
          public string EntryNo { get; set; }
          [Column("entry_line")]
          public string EntryLine { get; set; }
          [Column("plan_defect_rate")]
          public double PlanDefectRate { get; set; }
          [Column("complete_sign")]
          public string CompleteSign { get; set; }
          [Column("result_qty")]
          public double ResultQty { get; set; }
     }
}
