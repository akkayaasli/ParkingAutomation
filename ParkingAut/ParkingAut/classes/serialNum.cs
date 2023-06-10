using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingAut.classes
{
    class serialNum
    {
        public int ID { get; set; }

        public int MarkaID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string seri { get; set; }

        public virtual brands brands { get; set; }

        public virtual ICollection<VehicleParkingInformation> VehicleParkingInformations { get; set; }

    }
}
