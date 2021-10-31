using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZenoBlogg
{
    public partial class zPostMe : System.Web.UI.Page
    {

        ZenoBackend client = new ZenoBackend();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string DefaultFileDir = "img\\";
        protected void create_article(object sender, EventArgs e)
        {





            string filename = "";

            try
            {
                FileUploader.SaveAs(Server.MapPath(DefaultFileDir) +
                     FileUploader.FileName);

                filename = FileUploader.PostedFile.FileName;

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }


            bool isCreated = client.createArticle(title.Value,date.Value,body.Value,"img/"+filename,author.Value);

            if(isCreated == true)
            {
                Response.Redirect("zManageMe.aspx");
            }
            else
            {
                Response.Redirect("zPostMe.aspx");
            }
           
        }

      
    }
}