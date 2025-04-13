using System;
using System.Linq;
using RafiReceiptsApp.Models; // Ensure namespace corresponds to your data model
using Microsoft.EntityFrameworkCore;

namespace RafiReceiptsApp.Services
{
    public class ReceiptService
    {
        /// <summary>
        /// Generates and saves a receipt with all necessary token info.
        /// </summary>
        /// <param name="newReceipt">The receipt object with user-entered data.</param>
        /// <returns>The generated receipt with token and queue numbers assigned.</returns>
        public Receipt GenerateAndSaveReceipt(Receipt newReceipt)
        {
            // Basic validations – you can expand these as needed
            if (string.IsNullOrWhiteSpace(newReceipt.PatientName))
                throw new ArgumentException("Patient Name is required.");
            if (string.IsNullOrWhiteSpace(newReceipt.TokenType))
                throw new ArgumentException("Token Type is required.");
            if (newReceipt.Fee < 0)
                throw new ArgumentException("Fee cannot be negative.");

            // Set the creation date (this will help with queue calculation)
            newReceipt.CreatedAt = DateTime.Now;

            // Assign a token number based on total count (this is a simple example).
            // In a real-world scenario, you might want a more robust sequence generator.
            using (var context = new ApplicationDbContext())
            {
                // Count all receipts to assign a global token number
                newReceipt.TokenNumber = context.Receipts.Count() + 1;

                // Calculate queue number for today's receipts of the same token type
                newReceipt.QueueNumber = context.Receipts
                    .Where(r => r.TokenType == newReceipt.TokenType && r.CreatedAt.Date == DateTime.Today)
                    .Count() + 1;

                // Save the receipt into the database
                context.Receipts.Add(newReceipt);
                context.SaveChanges();
            }

            return newReceipt;
        }
    }
}
