using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax_Using_GetData_in_ASP.NET_MVC.Models
{
    public class WorkflowBL
    {
        public List<FindShipmentStatusModel> GetlogisticFileUploadStatus(string CourrierId, string ShipmentDate)
        {
            var Result = new List<FindShipmentStatusModel>();
            using (var dl = GetDL<IWorkflowDL>())
            {
                Result = dl.GetlogisticFileUploadStatus(CourrierId, ShipmentDate);
            }
            return Result;

        }
    }
}