using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace RafiReceiptsApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<PriceSetting> PriceSettings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                try
                {
                    // Get the directory where the executable is located.
                    string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string dataFolder = Path.Combine(exeDirectory, "Data");

                    // Check if the base directory is writable.
                    if (!DirectoryHelper.IsDirectoryWritable(exeDirectory))
                    {
                        // If the folder where the EXE resides is not writable,
                        // fall back to the user's LocalApplicationData folder.
                        string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                        dataFolder = Path.Combine(localAppData, "RafiReceiptsApp");
                    }

                    // Ensure the data folder exists.
                    if (!Directory.Exists(dataFolder))
                    {
                        Directory.CreateDirectory(dataFolder);
                    }

                    // Construct the full path to the database file.
                    string dbPath = Path.Combine(dataFolder, "HospitalReceipts.db");

                    // Log the database path for debugging.
                    System.Diagnostics.Debug.WriteLine($"[DEBUG] Database path: {dbPath}");

                    // Configure SQLite using the absolute path.
                    optionsBuilder.UseSqlite($"Data Source={dbPath};Cache=Shared");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[ERROR] OnConfiguring: {ex.Message}");
                    throw;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial PriceSetting data.
            modelBuilder.Entity<PriceSetting>().HasData(
                new PriceSetting { Id = 1, Category = "USG", SubType = "Abdominal and Pelvis", Price = 700.00m },
                new PriceSetting { Id = 2, Category = "USG", SubType = "Scrotal", Price = 1200.00m },
                new PriceSetting { Id = 3, Category = "USG", SubType = "Breast", Price = 1200.00m },
                new PriceSetting { Id = 4, Category = "USG", SubType = "Mass", Price = 1200.00m },
                new PriceSetting { Id = 5, Category = "USG", SubType = "TVS", Price = 1200.00m },
                new PriceSetting { Id = 6, Category = "USG", SubType = "Anomaly", Price = 1500.00m },
                new PriceSetting { Id = 7, Category = "OPD", SubType = "", Price = 300.00m },
                new PriceSetting { Id = 8, Category = "ECG", SubType = "", Price = 200.00m },
                new PriceSetting { Id = 9, Category = "Dr", SubType = "Dr Zain", Price = 500.00m },
                new PriceSetting { Id = 10, Category = "Dr", SubType = "Dr Hammad", Price = 700.00m },
                new PriceSetting { Id = 11, Category = "Dr", SubType = "Dr Jawad", Price = 700.00m },
                new PriceSetting { Id = 12, Category = "Dr", SubType = "Dr Fizza", Price = 700.00m }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
