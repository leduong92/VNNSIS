using System.ComponentModel.DataAnnotations.Schema;

namespace VNNSIS.Core.Entities
{
     public class BaseEntity
     {
          [Column("id")]
          public int Id { get; set; }
     }
}