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


            return View();

        }

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


        public ActionResult Get_Vhicle_Types()
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
         



    }
}