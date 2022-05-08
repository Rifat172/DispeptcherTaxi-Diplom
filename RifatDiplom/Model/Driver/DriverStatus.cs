using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RifatDiplom.Model.Driver
{
    [Table("DriversStatus", Schema = "dbo")]
    public class DriverStatus
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public Drivers Drivers { get; set; }
    }
}
