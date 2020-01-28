using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vehicle_Management.Models
{
    public class Employees
    {
   
        [Key]

        public int Employee_Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Employee_Code { get; set; }

        public Nullable<DateTime> DOJ { get; set; }

        public Nullable<int> Designation { get; set; }
        public Nullable<int> Employee_Type { get; set; }
    }
}