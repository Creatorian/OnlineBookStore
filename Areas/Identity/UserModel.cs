﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Areas.Identity
{
    public class UserModel
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public IQueryable<SelectListItem> Roles { get; set; }

        public string RoleId { get; set; }

        public string RoleName { get; set; }



    }
}
