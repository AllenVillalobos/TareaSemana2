using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaSemana2.Paginas
{
    public partial class Ejercisio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void bntVerificar(object sender, EventArgs e)
        {
            int edad;
            if (int.TryParse(txtEdad.Text, out edad))
            {
                if (edad >= 0 && edad <= 11)
                {
                    lblMensaje.Text = "Usted esta en la Niñez";
                    lblMensaje.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    if (edad >= 12 && edad <=17)
                    {
                        lblMensaje.Text = "Usted esta en la Adolecencia";
                        lblMensaje.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        if(edad >= 18 && edad <= 64) { 
                        lblMensaje.Text = "Usted esta en la Adultez";
                        lblMensaje.ForeColor = System.Drawing.Color.Azure;
                        }
                        else
                        {
                            if (edad >= 65)
                            {
                                lblMensaje.Text = "Usted esta en la Vejez";
                                lblMensaje.ForeColor = System.Drawing.Color.Gold;
                            }
                        }
                    }
                }
            }
            else
            {
                lblMensaje.Text = "Ingrese Una Edad Valida";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}