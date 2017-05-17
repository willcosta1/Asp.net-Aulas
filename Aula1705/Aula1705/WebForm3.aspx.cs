using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public float v1 { get; set; }
        public float v2 { get; set; }
        public float res { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //v1 = 0;
                //v2 = 0;
            }
        }

        protected void btnSomar_Click(object sender, EventArgs e)
        {
            v1 = float.Parse(txtValor1.Text); // v1 tem que ser viewstate
            v2 = float.Parse(txtValor2.Text);
            res = v1 + v2;
            txtSoma.Text = res.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            Session.Add("valorv1", double.Parse(txtValor1.Text)); // txtValor1.text
            Session.Add("valorv2", double.Parse(txtValor2.Text));
            Response.Redirect("~/WebForm4.aspx");
        }
    }
}