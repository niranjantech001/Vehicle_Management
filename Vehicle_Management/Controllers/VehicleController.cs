using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
                vehicleDetails_list = context.Vehicles.ToList();

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

        public ActionResult View_Vehicle(int Vehicle_Id)
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
                    entities.Vehicles.Add(objvehicle);
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

        public JsonResult Assign_Vehicle(Vehicle_Assign _vehicle_Assign)
        {

            using (var context = new VehicleContext())
            {
                try {

                    _vehicle_Assign.Assigned_Date = DateTime.Now;
                    _vehicle_Assign.Reason = "";
                   
                    context.Vehicle_Assign.Add(_vehicle_Assign);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {

                }
                
            }

            return Json(_vehicle_Assign);



        }

        public ActionResult Test6()
        {

            return View();
        }


        public async Task<ActionResult> Vehicle_Assign()
        {


            TempData["User_Id"] = 1;
            TempData["Date"] = DateTime.Now;


            List<Vehicle_Assign_Detaials> _List_vehicle_Assign_Detaials = new List<Vehicle_Assign_Detaials>();


            using (var context = new VehicleContext())
            {
                SqlParameter param1 = new SqlParameter("@Trans", "SELECT_ASSGNED_DETAILS");
              
                var employee = await context.Database.SqlQuery<Vehicle_Assign_Detaials>("Usp_Vehicle_Assign @Trans", param1).ToListAsync();

                _List_vehicle_Assign_Detaials = employee.ToList();
            }



           
            return View("Vehicle_Assign", _List_vehicle_Assign_Detaials);





        }

      

        public ActionResult Test7()
        {

            return View();
        }

        public class SelectListItem
        {

            public int Value { get; set; }

            public string Text { get; set; }
        }
        [HttpPost]
        public JsonResult Get_Vehicle_Number()
        {

            List<VehicleDetails> Vehicle_List = new List<VehicleDetails>();

            using (var Context = new VehicleContext())
            {
                Vehicle_List = Context.Vehicles.ToList();
            }

            List<SelectListItem> Selected_List = new List<SelectListItem>();
            foreach (var item in Vehicle_List)
            {

                Selected_List.Add(new SelectListItem
                {
                    
                    Value=item.Vehicle_Id,
                    Text=item.Vehicle_Number

                });
            }

            return Json(Selected_List,JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public JsonResult Get_Employee_Name()
        {

            List<Employees> Employees_List = new List<Employees>();
            using (var Context = new VehicleContext())

            {

                Employees_List = Context.Employees.ToList();

            }

            List<SelectListItem> Selected_Employee_List = new List<SelectListItem>();

            foreach (var item in Employees_List)
            {
                Selected_Employee_List.Add(new SelectListItem {
                    Value = item.Employee_Id,
                    Text = item.First_Name + " " + item.Last_Name

                });
            }

            return Json(Selected_Employee_List, JsonRequestBehavior.AllowGet);


        }
        [HttpPost]
        public JsonResult Get_Vehicle_Type()
        {
            List<Vehicle_Types> vehicles_list = new List<Vehicle_Types>();

            using (var context = new VehicleContext())
            {

                vehicles_list = context.vehicle_Types.ToList();

            }

            List<SelectListItem> Selected_Vehicle_Type_List = new List<SelectListItem>();

            foreach (var item in vehicles_list)
            {

                Selected_Vehicle_Type_List.Add(new SelectListItem
                {
                    Value = item.Vehicle_Type_Id,
                    Text = item.Vehicle_Type
                });
            }

            return Json(Selected_Vehicle_Type_List,JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult Get_Years()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            using (var context = new VehicleContext())
            {
               

                SqlParameter sqlParameter = new SqlParameter("@Trans", "SELECT_YEAR");

                var Years = context.Database.SqlQuery<int>("Usp_General @Trans", sqlParameter).ToList();



                foreach (var item in Years)
                {

                    listItems.Add(new SelectListItem {
                        Value=int.Parse(item.ToString()),
                        Text=item.ToString()

                    });

                }
               
            }

            return Json(listItems,JsonRequestBehavior.AllowGet);
        }

       

    }
}