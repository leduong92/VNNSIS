namespace VNNSIS.BackendApi.Dtos
{
     public class TmPostMachineOsReturnDto
     {
          public string LineNo { get; set; }
          public string PressNo { get; set; }
          public string PressName { get; set; }
          public string LocationCd { get; set; }
          public int? Temperature { get; set; }
          public string PlcM { get; set; }
          public string PlcM1 { get; set; }
          public string PlcM2 { get; set; }
          public string Ip { get; set; }
          public string PlcM3 { get; set; }
     }
}