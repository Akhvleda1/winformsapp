using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_app_using_EF_core.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public DateTime? DateOfBirth { get; set; }

        [MaxLength(100)]
        public string? PhoneNumber { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
