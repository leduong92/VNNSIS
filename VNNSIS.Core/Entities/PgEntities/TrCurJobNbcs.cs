﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     [Table("tr_cur_job_nbcs")]
     public class TrCurJobNbcs
     {
          public char? RecordStatus { get; set; }
          public int? EntryDate { get; set; }
          public int? EntryTime { get; set; }
          public int? UpdateDate { get; set; }
          public int? UpdateTime { get; set; }
          public string EntryTerminalId { get; set; }
          public string ProgramId { get; set; }
          public string UpdateUserCode { get; set; }
          public string CompanyCode { get; set; }
          public string PlantCode { get; set; }
          public string JobOrderNo { get; set; }
          public char? DataTransferCompleteSign { get; set; }
          public string ErrSign { get; set; }
          public string ParentJobOrderNo { get; set; }
          public char? DivideSign { get; set; }
          public string ManufacturedCuring { get; set; }
          public string ListTypeRubber { get; set; }
          public string ListTypeParts { get; set; }
          public string PurchaseOrder { get; set; }
          public char? ProcessSign7 { get; set; }
          public char? ProcessSign8 { get; set; }
          public char? ProcessSign9 { get; set; }
          public char? ProcessSign10 { get; set; }
          public char? UrgentScheduleSign { get; set; }
          public char? MachineSetUpSign { get; set; }
          public char? FinalSign { get; set; }
          public char? JisSign { get; set; }
          public char? SetItemSign { get; set; }
          public string FinishedGoodsCode { get; set; }
          public string CustomerCode { get; set; }
          public char? LimitationItemSign { get; set; }
          public char? MpCode { get; set; }
          public char? EnterpriseCode { get; set; }
          public string LineGroup { get; set; }
          public string LineNo { get; set; }
          public string PressNo { get; set; }
          public string DataNo { get; set; }
          public string MpsNo { get; set; }
          public double? CoQty { get; set; }
          public int? CoDueDate { get; set; }
          public string CustomerOrderNo { get; set; }
          public string SetItemCoLineNo { get; set; }
          public char? RoundUnit { get; set; }
          public char? PackingType { get; set; }
          public char? PackingPackageType { get; set; }
          public char? PackingLabelType { get; set; }
          public char? PackingLabelTypeSign { get; set; }
          public double? PackQty { get; set; }
          public char? BoxLabelType { get; set; }
          public char? BoxLabelPrintType { get; set; }
          public double? BoxQty { get; set; }
          public string VendorCode { get; set; }
          public string ExternalFabricationPoNo { get; set; }
          public string NicknameNo { get; set; }
          public string MaterialMark1 { get; set; }
          public string CompoundMark1 { get; set; }
          public string MaterialMark2 { get; set; }
          public string CompoundMark2 { get; set; }
          public string MetalCaseMaterialCode { get; set; }
          public string SpringMaterialCode { get; set; }
          public string OtherMaterialType { get; set; }
          public char? PartialShipmentSign { get; set; }
          public char? DeliveryType { get; set; }
          public string InternalOrderFromPlantCode { get; set; }
          public string CostAccountingDivision { get; set; }
          public string InternalOrderFromSector { get; set; }
          public char? StockItemSign { get; set; }
          public int? CavityQty { get; set; }
          public int? MoldPlateQty { get; set; }
          public int? Rotation { get; set; }
          public double? CuringQty { get; set; }
          public double? GoodItemQty { get; set; }
          public double? CarryOverGoodItemQty { get; set; }
          public char? CapabilitySign { get; set; }
          public int? CuringDate { get; set; }
          public char? OrderType { get; set; }
          public int? BoxLabelQty { get; set; }
          public double? StockInOrder1 { get; set; }
          public int? InspectionCardPrintQty { get; set; }
          public char? LatestLabelSign { get; set; }
          public double? LatestStockInOrder { get; set; }
          public char? ReScheduleSign { get; set; }
          public char? PartsPurchaseOrderSign { get; set; }
          public int? PlannedStockInDate { get; set; }
          public double? StockInOrderQty { get; set; }
          public char? SpecialSpecificationSign { get; set; }
          public char? InternalImportantSign1 { get; set; }
          public char? FirstMassProductionRoute { get; set; }
          public string CoatingMaterialType { get; set; }
          public string Mold { get; set; }
          public double? PreProcessDays { get; set; }
          public double? PostProcessDay { get; set; }
          public string MoldDivideSign { get; set; }
          public string SpecialProcessCode { get; set; }
          public int? JobTagDivideQty { get; set; }
          public int? ExtensiveJobSchedulingJobTagQty { get; set; }
          public char? GoodItemControlSign { get; set; }
          public string PressNo2 { get; set; }
          public string PressNo3 { get; set; }
          public string PressNo4 { get; set; }
          public string PressNo5 { get; set; }
          public string PressNo6 { get; set; }
          public string PressNo7 { get; set; }
          public string PressNo8 { get; set; }
          public string LotNo { get; set; }
          public string PaperVerificationMark { get; set; }
          public int? PaperVerificationNo { get; set; }
          public char? UpdateRequestSign { get; set; }
          public char? DisposalSign { get; set; }
          public string TagNo { get; set; }
          public string TotalTagNo { get; set; }
          public char? StockDataType { get; set; }
          public string TransactionNo { get; set; }
          public string EntryNo { get; set; }
          public string EntryLine { get; set; }
          public double? PlanDefectRate { get; set; }
          public char? CompleteSign { get; set; }
          public double? ResultQty { get; set; }
     }
}
