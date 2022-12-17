using System;
using System.Collections.Generic;

namespace BlazorApp1.Server.models
{
    public partial class AspNetUserRole
    {
        public string UserId { get; set; } = null!;
        public string RoleId { get; set; } = null!;

        public virtual AspNetRole Role { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
