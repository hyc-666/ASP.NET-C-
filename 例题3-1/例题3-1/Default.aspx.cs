using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 例题3_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void ImagineButton1_Click(object sender,ImageClickEventArgs e)
        {
            Response.Redirect("Information.aspx");
        }
    }
}