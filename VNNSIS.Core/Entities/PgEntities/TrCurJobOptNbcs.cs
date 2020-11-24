using System;
using System.Collections.Generic;

namespace VNNSIS.Core.Entities.PgEntities
{
     public class TrCurJobOptNbcs
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
          public string TransactionNo { get; set; }
          public char? DataTransferCompleteSign { get; set; }
          public string ErrSign { get; set; }
          public string ParentJobOrderNo { get; set; }
          public char? DivideSign { get; set; }
          public char? ProcessSign10 { get; set; }
          public string CustomerItem { get; set; }
          public string MainStockLocation { get; set; }
          public string ShipToStockLocation { get; set; }
          public string StockAccountNo { get; set; }
          public int? CuringTemperature1 { get; set; }
          public int? CuringTemperature2 { get; set; }
          public double? CuringTimeSec { get; set; }
          public double? CuringPressure { get; set; }
          public double? PostCureTimeHour { get; set; }
          public int? PostCureTemperature { get; set; }
          public string PostCureCondition { get; set; }
          public char? MoldSubstituteSign { get; set; }
          public string MoldWashingMethod { get; set; }
          public double? MoldWashingFrequency { get; set; }
          public string MoldWashingUnit { get; set; }
          public string AdditionalSpecCode1 { get; set; }
          public string AdditionalSpecName1 { get; set; }
          public string AdditionalSpecCode2 { get; set; }
          public string AdditionalSpecName2 { get; set; }
          public string AdditionalSpecCode3 { get; set; }
          public string AdditionalSpecName3 { get; set; }
          public string AdditionalSpecCode4 { get; set; }
          public string AdditionalSpecName4 { get; set; }
          public string AdditionalSpecCode5 { get; set; }
          public string AdditionalSpecName5 { get; set; }
          public string OtherAdditionalSpec1 { get; set; }
          public string OtherAdditionalSpec2 { get; set; }
          public string JobOrder { get; set; }
          public string SalesRequest2 { get; set; }
          public string SalesRequest3 { get; set; }
          public string SalesRequest4 { get; set; }
          public char? UpdateRequestSign { get; set; }
          public char? DisposalSign { get; set; }
          public string CementCoatingMark { get; set; }
          public string SurfaceTreatmentLineGroup { get; set; }
          public string CementCoatingLineGroup { get; set; }
          public char? BoxSpecified { get; set; }
          public string ConsolidateCo { get; set; }
          public string ConsolidateCoLine { get; set; }
          public double? CosolidCoQty { get; set; }
          public double? FinishedGoodsWeight { get; set; }
          public char? DoubleCuring { get; set; }
          public char? InternalImportantSign2 { get; set; }
          public char? InternalImportantSign3 { get; set; }
          public string ScheduleMemo1 { get; set; }
          public string ScheduleMemo2 { get; set; }
          public string ScheduleMemo3 { get; set; }
          public double? AvailableQty { get; set; }
     }
}
