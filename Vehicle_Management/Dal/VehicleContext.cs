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


        public DbSet<VehicleDetails> vehicles { get; set; }

        public DbSet<Vehicle_Types> vehicle_Types { get; set; }
        public ICollection<Vehicle_Types> vehicle_Types_List { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer<VehicleContext>(null);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
       
    }
}