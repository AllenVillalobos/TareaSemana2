using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaSemana2.Paginas
{
    public partial class Ejercisio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void dividir(object sender,EventArgs e)
        {
            int dividendo;
            int divisor;
            double resultado;
            if(int.TryParse(txtdividendo.Text, out dividendo) && int.TryParse(txtdivisor.Text,out divisor))
            {
                if(divisor == 0)
                {
                    lblMensaje.Text = "Estas Tratando de Dividir por 0. Pon otro Divisor";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    resultado = dividendo / divisor;
                    lblMensaje.Text = "El resultado es: "+resultado;
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblMensaje.Text = "Revisa los Campos, ya que uno de estos no cuenta con numeros adecuados";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {

        }
    }
}