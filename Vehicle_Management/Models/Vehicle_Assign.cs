using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vehicle_Management.Models
{
[Table("Vehicle_Assign")]
    public class Vehicle_Assign
    {

        [Key]
        public int Vehicle_Assign_Id { get; set; }
        public int Vehicle_Id { get; set; }
        public int Assign_To { get; set; }
        public int Assigned_By { get; set; }
        public Nullable<DateTime> Assigned_Date { get; set; }
        public string Reason { get; set; }
        public bool Status { get; set; }
        
    }
}