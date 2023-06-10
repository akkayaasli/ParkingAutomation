﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingAut.classes
{
    class CarParkDBContext : DbContext
    {
        public DbSet<brands> TableBrands { get; set; }

        public DbSet<serialNum> TableSerialNum { get; set; }

        public DbSet<CarParkingSpaces> TableCarParkingSpaces { get; set; }
        
        public DbSet<customer> TableCustomer { get; set; }

        public DbSet<VehicleParkingInformation> TableVehicleParkingInformation { get; set; }

        public DbSet<Sales> TableSales { get; set; }

    }
}
