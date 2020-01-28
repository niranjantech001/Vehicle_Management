using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehicle_Management.Models
{
    public class Vehicle_Assign_Detaials
    {

        public int Vehicle_Assign_Id { get; set; }

        public string Vehicle_Type { get; set; }
        public string Vehicle_Number { get; set; }
        public string ASSIGNED_TO { get; set; }
        public string ASSIGNED_BY { get; set; }
        public Nullable<DateTime> Assigned_Date { get; set; }

    }
}