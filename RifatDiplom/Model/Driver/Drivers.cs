using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RifatDiplom.Model.Driver
{
    [Table("Drivers", Schema = "dbo")]
    public class Drivers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string NickName { get; set; }
        public string Car { get; set; }
        public int Pevenue { get; set; }
        public int Id_Status { get; set; }
        [ForeignKey("Id_Status")]

        public ICollection<DriverStatus> DriverStatus { get; set; }
    }
}
