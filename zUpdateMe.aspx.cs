using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ZenoBlogg
{

    public partial class zUpdateMe : System.Web.UI.Page
    {

        ZenoBackend client = new ZenoBackend();
      

        protected void update_article(object sender, EventArgs e)
        {



            int id = Int32.Parse(Request.QueryString["id"]);

            bool isUpdated = client.editArticle(id, title.Value, date.Value, body.Value, author.Value);

            if (isUpdated == true)
            {

                Session["loadedMoreThanOnce"] = null;
                Response.Redirect("zManageMe.aspx");
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);

            var article = client.getArticle(id);

            if (Session["loadedMoreThanOnce"] == null)
            {
                Session["loadedMoreThanOnce"] = false;
            }



            if (Boolean.Parse(Session["loadedMoreThanOnce"].ToString()) == false)
            {
                title.Value = article.Title;
                date.Value = article.Date;
                author.Value = article.Author;
                body.Value = article.Body;
                Session["loadedMoreThanOnce"] = true;
            }

            

        }


    }
}