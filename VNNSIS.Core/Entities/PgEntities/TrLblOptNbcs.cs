using System;
using System.Collections.Generic;

namespace VNNSIS.Core.Entities.PgEntities
{
     public class TrLblOptNbcs
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
          public string MpsNo { get; set; }
          public string TransactionNo { get; set; }
          public char? DataTransferCompleteSign { get; set; }
          public string JobOrderNo { get; set; }
          public string BoxCustomerName { get; set; }
          public string PackCustomerName { get; set; }
          public string BoxPartsNo { get; set; }
          public string PackPartsNo { get; set; }
          public string BoxComment1 { get; set; }
          public string PackComment1 { get; set; }
          public string BoxComment2 { get; set; }
          public string PackComment2 { get; set; }
          public string MsdonhangOs { get; set; }
          public char? CustDomestic { get; set; }
          public char? RefcoSign { get; set; }
     }
}
