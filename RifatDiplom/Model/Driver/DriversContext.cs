using System.Data.Entity;

namespace RifatDiplom.Model.Driver
{
    public class DriversContext : DbContext
    {
        public DriversContext() : base("RifatDiplom.Properties.Settings.OrderConn") { }

        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<DriverStatus> DriverStatus { get; set; }
    }
}
