﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile MemberProfile { get; set; }
    }
}
