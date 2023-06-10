﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingAut.classes
{
    class brands
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string MarkaAdi { get; set; }

        public virtual ICollection<serialNum> serialNum { get; set; } 
    }
}
