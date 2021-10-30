using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZenoBlogg
{
  
    public partial class Index1 : System.Web.UI.Page
    {

        ZenoBackend client = new ZenoBackend();
        protected void Page_Load(object sender, EventArgs e)
        {

			dynamic articles = client.getArticles();

            string display = "";


			foreach (Article row in articles)
			{
				
				display += "<div class='col-lg-3 mb-4'>";
				
				display += "<div class='card'>";
				display += "<img src = '"+row.Image+"' alt='' class='card-img-top'>";
				display += "<div class='card-body'>";
				display += "<h5 class='card-title'>"+row.Title+"</h5>";
				display += "<div class='text-muted'>";
				display += "<p class='card-text'>"+row.Body+"</p>";

				display += "</div>";
				display += "<p class='card-text'>Author : "+row.Author+"</p>";
				display += "<p class='text-muted card-text'> Date posted : " + row.Date + "</p>";
				display += "<a href='Article.aspx?article="+row.Id+"'>";
				display += "<p class='text-capitalize'><i class='fas fa-long-arrow-alt-right ml-2'></i>read more</p>";
				display += "</a>";
				display += "</div>";
				display += "</div>";
				
				display += "</div>";
				
			}

			displayArticles.InnerHtml = display;


		}


		protected void sub(object sender, EventArgs e)
		{

			bool sub = client.subscription(email.Value);

			if(sub == true)
            {
				//display positive message
            }
            else
            {

            }


		}
	}
}