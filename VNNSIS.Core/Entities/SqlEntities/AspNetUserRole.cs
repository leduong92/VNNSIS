﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VNNSIS.Core.Entities.SqlEntities
{
     public partial class AspNetUserRole
     {
          public string UserId { get; set; }
          public string RoleId { get; set; }

          public virtual AspNetUser User { get; set; }
     }
}
