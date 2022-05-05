using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Models
{
    public class UserUpdateViewModel
    {
        public string Namesurname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string imageUrl { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
    }
}
