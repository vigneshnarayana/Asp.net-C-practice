using Ajax_Using_GetData_in_ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax_Using_GetData_in_ASP.NET_MVC.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FindStatus(string CourierName, string dtmTime)
        {

            var result = new List<FindShipmentStatusModel>();
            using (WorkflowBL bl = new WorkflowBL())
            {
                int counts;
                result = bl.GetlogisticFileUploadStatus(CourierName, dtmTime);

                foreach (var items in result)
                {
                    try
                    {
                        if (items.AWBNO != "")
                        {
                            try
                            {
                                var value = items.AWBNO;
                                var fileCheck = items.AWBNO + "_FileUploadResponse.txt";
                                var filePathLocation = ConfigurationManager.AppSettings["filePathLocation"];
                                String filePath = @"" + filePathLocation + "" + value + "_FileUploadResponse.txt";
                                string[] files = System.IO.Directory.GetFiles(@"" + filePathLocation + "", fileCheck);

                                if (files.Count() == 0)
                                {
                                    var filepath_Arichive = ConfigurationManager.AppSettings["filePathLocation_Arichive"];
                                    filePath = @"" + filepath_Arichive + "" + value + "_FileUploadResponse.txt";
                                    files = System.IO.Directory.GetFiles(@"" + filepath_Arichive + "", fileCheck);
                                }
                                bool isvalue = false;

                                if (files[0] == filePath)
                                {
                                    isvalue = true;

                                    List<String> file = new List<string>();
                                    file = System.IO.File.ReadAllLines(filePath).ToList();
                                    foreach (String a in file)
                                    {
                                        counts = Regex.Split(a, @"<HighestSeverity>SUCCESS").Count();
                                        if (counts.Equals(2))
                                        {
                                            items.Status = true;
                                        }
                                        else
                                        {
                                            items.Status = false;
                                        }

                                    }

                                }
                                else
                                {
                                    isvalue = false;
                                }




                            }
                            catch (Exception err) { }


                        }
                        else { }
                    }
                    catch (Exception err) { }



                }


                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
    }
}