using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appnotification
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string FilePath = Server.MapPath("~/Files/Android.apk");

            Response.AppendHeader("content-disposition", "attachment; filename=" + System.IO.Path.GetFileName(FilePath));

            Response.ContentType = "application/vnd.android.package-archive";

            Response.WriteFile(FilePath);
        }
    }
}