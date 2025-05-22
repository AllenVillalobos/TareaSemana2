using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaSemana2.Paginas
{
    public partial class Ejercisio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnConvertirGrados(object sender, EventArgs e)
        {
            double grados;
            double fahrenheit;
            if (double.TryParse(txtGradosCelsius.Text, out grados))
            {
                fahrenheit = (grados * (9.0/5.0)) + 32;
                lblMensaje.Text = "Su temperatura: " + grados + " en Celsius a Fahrenheit es: " + fahrenheit;
                lblMensaje.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblMensaje.Text = "Ingrese una Temperatura en numeros";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}