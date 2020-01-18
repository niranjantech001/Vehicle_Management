using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vehicle_Management.Dal;
using Vehicle_Management.Models;

namespace Vehicle_Management.Controllers
{
    public class VehicleController : Controller
    {
        VehicleContext objVehicleContext = new VehicleContext();
        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vehicle_List()
        {

            List<VehicleDetails> vehicleDetails_list = new List<VehicleDetails>();

            using (var context = new VehicleContext())
            {
                vehicleDetails_list = context.vehicles.ToList();

                //  var Query = (from result in context.Vehicle_List
                //             select new VehicleDetails
                //             {


                //                 Vehicle_Number = result.Vehicle_Number
                //             });
                //vehicleDetails_list = Query.ToList();

                return View("Vehicle_List", vehicleDetails_list);

            }
          


            //    List<VehicleDetails> vehicleDetails_list = new List<VehicleDetails>();
            //using (var ObjContext = new VehicleContext())
            //{
            //    var List = (from v in objVehicleContext.vehicles
            //                select new VehicleDetails
            //                {

            //                    Vehicle_Number=v.Vehicle_Number,
            //                    Vehicle_Engine=v.Vehicle_Engine,
            //                    Vehicle_Type=v.Vehicle_Type,
            //                    Colour=v.Colour,
            //                    Make_of_Vehicle=v.Make_of_Vehicle,
            //                    Purchase_Year=v.Purchase_Year


            //                });

            //    vehicleDetails_list = List.ToList();

            //}

            //return View("Vehicle_List", vehicleDetails_list);

        }

        //public JsonResult Vehicle_List_Details()
        //{

        //  //  return Json(vehicleDetails_list, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult Add_New_Vehicle()

        {


            return View();




        }

        public ActionResult Test()
        {
            return View();

        }

        public ActionResult Test1()
        {
            return View();

        }
        public ActionResult Test2()
        {
            return View();
        }

        public ActionResult Test3()
        {

            return View();
        }

        public ActionResult Test4()
        {
            return View();
        }

        public ActionResult Test5()
        {
            return View();
        }
        public ActionResult Upload()
        {
            bool isSavedSuccessfully = true;
            string fName = "";
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    fName = file.FileName;
                    if (file != null && file.ContentLength > 0)
                    {
                        var path = Path.Combine(Server.MapPath("~/Uploads"));
                        string pathString = System.IO.Path.Combine(path.ToString());
                        var fileName1 = Path.GetFileName(file.FileName);
                        bool isExists = System.IO.Directory.Exists(pathString);
                        if (!isExists) System.IO.Directory.CreateDirectory(pathString);
                        var uploadpath = string.Format("{0}\\{1}", pathString, file.FileName);
                        file.SaveAs(uploadpath);
                    }
                }
            }
            catch (Exception ex)
            {
                isSavedSuccessfully = false;
            }
            if (isSavedSuccessfully)
            {
                return Json(new
                {
                    Message = fName
                });
            }
            else
            {
                return Json(new
                {
                    Message = "Error in saving file"
                });
            }
        }

        public JsonResult Add_Vehicle(VehicleDetails objvehicle)
        {

           
            using (VehicleContext entities = new VehicleContext())
            {

                try
                {
                    entities.vehicles.Add(objvehicle);
                    entities.SaveChanges();
                }
          
                catch(Exception ex)
                {


                }

            }

                return Json(objvehicle);
        }


        public JsonResult Get_Vhicle_Types()
        {
            List<Vehicle_Types> vehicle_Types_List = new List<Vehicle_Types>();


            using (var objcontext = new VehicleContext())
            {

                 vehicle_Types_List = objcontext.vehicle_Types.ToList();

                return Json(vehicle_Types_List, JsonRequestBehavior.AllowGet);


            }

        }

        public ActionResult Test6()
        {

            return View();
        }


        public ActionResult Vehicle_Assign()
        {


            List<VehicleDetails> vehicleDetails_list = new List<VehicleDetails>();

            using (var context = new VehicleContext())
            {
                vehicleDetails_list = context.vehicles.ToList();

                //  var Query = (from result in context.Vehicle_List
                //             select new VehicleDetails
                //             {


                //                 Vehicle_Number = result.Vehicle_Number
                //             });
                //vehicleDetails_list = Query.ToList();

                return View("Vehicle_Assign", vehicleDetails_list);

            }


            
            

        }

        public ActionResult Test7()
        {

            return View();
        }

    }
}