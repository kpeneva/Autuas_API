using Autuas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autuas.Models
{
    public class ReflectiveDiaryLog
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime DateLog { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
