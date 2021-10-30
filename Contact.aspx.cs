using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZenoBlogg
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void send(object sender, EventArgs e)
        {
            Process.Start("mailto:malesaglen6@gmail.com?subject=" + name.Value + "&body="
             + message.Value);
        }
    }
}