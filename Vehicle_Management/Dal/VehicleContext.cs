using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Vehicle_Management.Models;

namespace Vehicle_Management.Dal
{
    public class VehicleContext:DbContext
    {

        public VehicleContext()
            :base("Vehicle_Connection")
        {


        }


        public DbSet<VehicleDetails> Vehicles { get; set; }

        public DbSet<Vehicle_Types> vehicle_Types { get; set; }
  
        public DbSet<Employees> Employees { get; set; }

        public DbSet<Vehicle_Assign> Vehicle_Assign { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer<VehicleContext>(null);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
       
    }
}