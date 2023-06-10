using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingAut.classes
{
    class customer
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar")]
    //adsoyad için karakter sınırlaması olmasın.

        public string AdiSoyadi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]

        public string Telefon { get; set; }

        [Column(TypeName = "varchar")]
        //adres için karakter sınırlaması olmasın.

        public string Adres { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(150)]

        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]

        public string Resim { get; set; }

        public DateTime Tarih { get; set; }
    }
}
