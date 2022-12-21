using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace motofix
{
    public class Motorcycle
    {
        [Key]
        public int ID { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }

        public Customer Customer { get; set; }
    }
}
