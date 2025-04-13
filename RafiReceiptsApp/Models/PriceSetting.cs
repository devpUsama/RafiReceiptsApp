using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafiReceiptsApp.Models
{
    public class PriceSetting
    {
        public int Id { get; set; }
        /// <summary>
        /// A general category for price settings (e.g., "USG", "OPD", "ECG", "Dr")
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// For USG category, SubType holds the specific USG type (e.g., "Abdominal and Pelvis", "Scrotal", etc.)
        /// For doctor categories, this would be the doctor's name.
        /// For OPD or ECG, SubType can be left blank if only one price is used.
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// The price for this specific setting.
        /// </summary>
        public decimal Price { get; set; }
    }
}
