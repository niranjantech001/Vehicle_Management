using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vehicle_Management.Models
{
    
    public class Vehicle_Types
    {
        
        [Key]
        public int Vehicle_Type_Id { get; set; }
        public string Vehicle_Type { get; set; }
    }
}