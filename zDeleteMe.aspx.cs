using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZenoBlogg
{
    public partial class zDeleteMe : System.Web.UI.Page
    {
        ZenoBackend client = new ZenoBackend();
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Int32.Parse(Request.QueryString["id"]);

            client.deleteArticle(id);


            Response.Redirect("zManageMe.aspx");

        }
    }
}