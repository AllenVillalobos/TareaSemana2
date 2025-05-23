using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaSemana2.Paginas
{
    public partial class Ejercisio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void primos(object sender, EventArgs e)
        {
            int limite = int.Parse(txtNumero.Text);
            string listaDeNumeros = "";

            for(int i=2; i <= limite; i++)
            {
                Boolean esPrimo = true;
                for (int j=2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    listaDeNumeros += " " + i;
                }
            }

            lblPrimos.Text = listaDeNumeros;
            lblPrimos.ForeColor = System.Drawing.Color.Green;
        }
    }
}