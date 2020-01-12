using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vehicle_Management.Models
{
    public class VehicleDetails
    {
        [Key]
        public int Vehicle_Id { get; set; }

        public int Vehicle_Type { get; set; }

        public string Purchase_Year { get; set; }

        public string Vehicle_Number { get; set; }
        public string Make_of_Vehicle { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public string Current_Mileage { get; set; }
        public int Vehicle_Engine { get; set; }

        public string Description { get; set; }
    }
}