﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Domain.Entities
{
    public class RentACarProcess
    {
        public int RentACarProcessId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PickUpLocation { get; set; }
        public int DropOfflocation { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string PickupDescription { get; set; }
        public string DropOffDescription { get; set; }
        public decimal TotalPrice { get; set; }



        [Column(TypeName = "Date")]
        public DateTime PickUpDate { get; set; }
        
        [Column(TypeName = "Date")]
        public DateTime DropOffDate { get; set; }
        
        [DataType(DataType.Time)]
        public TimeSpan PickUpTime { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan DropOffTime { get; set; }


    }
}
