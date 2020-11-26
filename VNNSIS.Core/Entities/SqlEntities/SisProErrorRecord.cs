﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VNNSIS.Core.Entities.SqlEntities
{
     public partial class SisProErrorRecord : BaseEntity
     {
          public string JobOrderNo { get; set; }
          public short OperationNumber { get; set; }
          public string FinishedGoodsCode { get; set; }
          public string LotNo { get; set; }
          public int? CavityQty { get; set; }
          public string LineNo { get; set; }
          public string RubberName { get; set; }
          public int? PlanCycle { get; set; }
          public decimal? PlanQty { get; set; }
          public decimal? UnitCost { get; set; }
          public decimal? UnitPrice { get; set; }
          public string JobStartDate { get; set; }
          public string JobEndDate { get; set; }
          public string OperationStartDate { get; set; }
          public string OperationEndDate { get; set; }
          public string MachineNo { get; set; }
          public int? OkQty { get; set; }
          public string ProgressOperationCode { get; set; }
          public short ProgressOperationSeq { get; set; }
          public string ProgressOperationName { get; set; }
          public string ErrorId { get; set; }
          public string ErrorName { get; set; }
          public string ErrorNameJp { get; set; }
          public short? ErrorQty { get; set; }
          public string Notes { get; set; }
          public string EntryDate { get; set; }
          public string EntryTime { get; set; }
          public string EntryUser { get; set; }
          public string UpdateDate { get; set; }
          public string UpdateTime { get; set; }
          public string UpdateUser { get; set; }
          public string Status { get; set; }
          public string ErrorNameEn { get; set; }
          public string CuringDate { get; set; }
          public string Department { get; set; }
          public string Area { get; set; }
          public string ProgramId { get; set; }
          public string PressNo { get; set; }
          public string Division { get; set; }
          public string Section { get; set; }
     }
}
