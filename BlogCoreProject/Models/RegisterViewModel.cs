using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Models
{
    public class RegisterViewModel
    {
        public string WriterName { get; set; }

        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public bool WriterStatus { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPasword { get; set; }
    }
}
