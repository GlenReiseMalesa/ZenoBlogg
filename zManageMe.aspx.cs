using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZenoBlogg
{
    public partial class zManageMe : System.Web.UI.Page
    {
        ZenoBackend client = new ZenoBackend();
        protected void Page_Load(object sender, EventArgs e)
        {

            dynamic articles = client.getArticles();

            string display = "";


            foreach (Article row in articles)
            {

                display += "<tr>";
                display += "<td> "+row.Title+" </td>";
                display += "<td><a href='zUpdateMe.aspx?id="+row.Id+"'><button type='button' class='btn btn-primary'>EDIT</button></a></td>";
                display += "<td><a href='zDeleteMe.aspx?id=" + row.Id + "'><button type='button' class='btn btn-danger'>DELETE</button></a></td>";
                display += "</tr>";
            }


            displayArticles.InnerHtml = display;
          
        }
    }
}