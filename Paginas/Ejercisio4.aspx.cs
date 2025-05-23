using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaSemana2.Paginas
{
    public partial class Ejercisio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void verificar(object sender, EventArgs e)
        {
            string contra = "Hola1234";
            string contrasennia = txtContrasennia.Text;
            int intentos = int.Parse(lblMensaje1.Text);

            if (contrasennia == contra && intentos >= 1)
            {
                lblMensaje1.Text = "3";
                lblMensaje1.Visible = false;
                lblMensaje2.Text = "La contraseña es correcta";
                lblMensaje2.ForeColor = System.Drawing.Color.Green;
            }
            else if (contrasennia != contra && intentos > 1)
            {
                intentos--;
                lblMensaje1.Text = "" + intentos;
                lblMensaje1.Visible = true;
                lblMensaje1.ForeColor = System.Drawing.Color.Red;
                lblMensaje2.Text = " :Intentos Restantes";
                lblMensaje2.ForeColor = System.Drawing.Color.Red;
            }
            else if (intentos <= 1)
            {
                intentos=0;
                lblMensaje1.Text = "0";
                lblMensaje1.Visible = true;
                lblMensaje1.ForeColor = System.Drawing.Color.Red;
                lblMensaje2.Text = " :Intentos Restantes, Has agotado todos los intentos";
                lblMensaje2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}