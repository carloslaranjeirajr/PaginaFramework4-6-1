using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWebTeste
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalcular_Click(object sender, EventArgs e)
        {
            LabelResultado.Text = (Convert.ToInt32(TextBoxPrimeiroNumero.Text) + (Convert.ToInt32(TextBoxSegundoNumero.Text))).ToString();
        }

        protected void TextBoxPrimeiroNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}