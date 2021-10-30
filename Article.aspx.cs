using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZenoBlogg
{
    public partial class Article : System.Web.UI.Page
    {
        ZenoBackend client = new ZenoBackend();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;

            id = Int32.Parse(Request.QueryString["article"]);

            Article article = client.getArticle(id);


            //display
            string display = "";

            display += "<div class='col-md-4'>";
            display += "<img src = '"+article.Image+"' style='height: 350px;width: 350px;' class='img-fluid rounded-start' alt='...'>";
            display += "</div>";
            display += "<div class='col-md-8'>";
            display += "<div class='card-body'>";
            display += "<h2 class='card-title'>"+article.Title+"</h2>";
            display += "<p class='card-text'>"+article.Body+"</p>";
            display += "</div>";
            display += "</div>";


            displayArticle.InnerHtml = display;

        }
    }
}