using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafiReceiptsApp.Models
{
    public class Receipt
    {
        public int Id { get; set; }                // Primary Key
        public string TokenType { get; set; }      // e.g., "OPD", "USG", etc.
        public string PatientName { get; set; }
        public string Address { get; set; }
        public string? Temperature { get; set; }
        public string? BloodPressure { get; set; }
        public decimal Fee { get; set; }
        public string? DoctorName { get; set; }     // For first three token types
        public int TokenNumber { get; set; }
        public int QueueNumber { get; set; }
        public string? USGType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
