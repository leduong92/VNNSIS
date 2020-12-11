using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities.PgEntities
{
     public class TrLblOptNbcs : BaseEntity
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
          [Column("transaction_no")]
          public string TransactionNo { get; set; }
          [Column("data_transfer_complete_sign")]
          public string DataTransferCompleteSign { get; set; }
          [Column("job_order_no")]
          public string JobOrderNo { get; set; }
          [Column("box_customer_name")]
          public string BoxCustomerName { get; set; }
          [Column("pack_customer_name")]
          public string PackCustomerName { get; set; }
          [Column("box_parts_no")]
          public string BoxPartsNo { get; set; }
          [Column("pack_parts_no")]
          public string PackPartsNo { get; set; }
          [Column("box_comment1")]
          public string BoxComment1 { get; set; }
          [Column("pack_comment1")]
          public string PackComment1 { get; set; }
          [Column("box_comment2")]
          public string BoxComment2 { get; set; }
          [Column("pack_comment2")]
          public string PackComment2 { get; set; }
          [Column("msdonhang_os")]
          public string MsdonhangOs { get; set; }
          [Column("cust_domestic")]
          public string CustDomestic { get; set; }
          [Column("refco_sign")]
          public string RefcoSign { get; set; }
     }
}
