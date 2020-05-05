using System;
using CCSOFTWARESOLUTIONS.Assets.Domain;
using Microsoft.EntityFrameworkCore;

namespace CCSOFTWARESOLUTIONS.Assets.Data
{
    public class AssetsContext : DbContext
    {
        public AssetsContext() : base() { }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Change the connection string here to your computer/lab computer
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-254CBRDD\SQLEXPRESS01;
                                          Database=AssetsTracking;
                                          Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data created here
            modelBuilder.Entity<AssetType>().HasData(
                new AssetType { Id = 1, Name = "Computer" },
                new AssetType { Id = 2, Name = "Monitor" },
                new AssetType { Id = 3, Name = "Phone" }


                );

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    Id = 1,
                    TagNumber = "1A1",
                    AssetTypeId = 1,
                    Manufacturer = "Dell",
                    Model = "CO61-410US",
                    Description = "Inspiron",
                    SerialNumber = "NXP-157-I"

                },
                new Asset
                {
                    Id = 2,
                    TagNumber = "2A1",
                    AssetTypeId = 1,
                    Manufacturer = "HP",
                    Model = "BO61-410US",
                    Description = "Hnspiron",
                    SerialNumber = "HXP-157-I"
                },
                new Asset
                {
                    Id = 3,
                    TagNumber = "3A1",
                    AssetTypeId = 1,
                    Manufacturer = "Acer",
                    Model = "AO61-410US",
                    Description = "Anspiron",
                    SerialNumber = "AXP-157-I"
                },
                new Asset
                {
                    Id = 4,
                    TagNumber = "4MA1",
                    AssetTypeId = 2,
                    Manufacturer = "Acer",
                    Model = "AMO61-410US",
                    Description = "AMnspiron",
                    SerialNumber = "AMXP-157-I"
                },
                new Asset
                {
                    Id = 5,
                    TagNumber = "3MA1",
                    AssetTypeId = 2,
                    Manufacturer = "LG",
                    Model = "LMO61-410US",
                    Description = "LMnspiron",
                    SerialNumber = "LMXP-157-I"
                },
                new Asset
                {
                    Id = 6,
                    TagNumber = "3HA1",
                    AssetTypeId = 2,
                    Manufacturer = "HP",
                    Model = "HMO61-410US",
                    Description = "HMnspiron",
                    SerialNumber = "HMXP-157-I"
                },
                new Asset
                {
                    Id = 7,
                    TagNumber = "3PA1",
                    AssetTypeId = 3,
                    Manufacturer = "Avaya",
                    Model = "APO61-410US",
                    Description = "APnspiron",
                    SerialNumber = "APXP-157-I"
                },
                new Asset
                {
                    Id = 8,
                    TagNumber = "3CA1",
                    AssetTypeId = 3,
                    Manufacturer = "Cisco",
                    Model = "CPO61-410US",
                    Description = "CPnspiron",
                    SerialNumber = "CPXP-157-I"
                },
                new Asset
                {
                    Id = 9,
                    TagNumber = "3PPA1",
                    AssetTypeId = 3,
                    Manufacturer = "Polycom",
                    Model = "PPO61-410US",
                    Description = "PPnspiron",
                    SerialNumber = "PPXP-157-I"
                }

                );

        }
    }

}
