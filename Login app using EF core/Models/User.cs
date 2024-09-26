using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_app_using_EF_core.Models
{
    public class User
    {
        public int Id {  get; set; }

        [MaxLength(50)]
        public string Name { get; set; } = null!;
        
        [MaxLength(200)]
        public string Email { get; set; } = null!;
        
        [MaxLength(200)]
        public string Password { get; set; } = null!;

        public UserInfo UserInfo { get; set; } = null!;
    }
}
