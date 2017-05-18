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
            double v1 = Convert.ToDouble(Session["valorv1"]);
            double v2 = Convert.ToDouble(Session["valorv2"]);
            txt9.Text = (v1 + v2).ToString();
            txt10.Text = (v1 - v2).ToString();
            txt11.Text = (v1 * v2).ToString();
            txt12.Text = (v1 / v2).ToString();
            txt1.Text = v1.ToString();
            txt3.Text = v1.ToString();
            txt5.Text = v1.ToString();
            txt7.Text = v1.ToString();
            txt2.Text = v2.ToString();
            txt4.Text = v2.ToString();
            txt6.Text = v2.ToString();
            txt8.Text = v2.ToString();

        }
    }
}