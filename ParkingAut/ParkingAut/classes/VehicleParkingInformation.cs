﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingAut.classes
{
    class VehicleParkingInformation
    {
        public int ID { get; set; }

        public int MusteriID { get; set; }


        [Column(TypeName = "varchar")]       
        public string AdiSoyadi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Telefon { get; set; }

        public int MarkaID { get; set; }

        public int SeriID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Plaka { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Yil { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Renk { get; set; }

        public int ParkYeriID { get; set; }

        [Column(TypeName = "varchar")]
      
        public string Aciklama { get; set; }

        public DateTime GirisTarihi { get; set; }

        public virtual CarParkingSpaces CarParkingSpaces { get; set; }

        public virtual brands brands { get; set; }

        public virtual serialNum serialNum { get; set; }
    }
}
