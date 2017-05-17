using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double v1SS = Convert.ToDouble(Session["valorv1"]);
            double v2SS = Convert.ToDouble(Session["valorv2"]);
            double res = v1SS+v2SS;
            txt9.Text = res.ToString();
        }
    }
}