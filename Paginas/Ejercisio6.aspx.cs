using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaSemana2.Paginas
{
    public partial class Ejercisio6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void calcularSalario(object sender, EventArgs e)
        {
            int horas = int.Parse(txtHoras.Text);
            int horasExtras = int.Parse(txtHorasExt.Text);
            double salarioPorHora = double.Parse(txtSalario.Text);
            double salarioHorasExtras = salarioPorHora * 1.5;
            double salarioExtra = salarioHorasExtras * horasExtras;
            double salarioTotal = (horas * salarioPorHora) + salarioExtra;
            double impuestoSSCC = salarioTotal * 0.055;
            double impuestoIVM = salarioTotal * 0.035;
            double impuestoTrabajador = salarioTotal * 0.01;
            double impuestoRenta = 0;
            if (salarioTotal <= 941000.0)
            {
                impuestoRenta = salarioTotal * 0;
            }
            else if (salarioTotal >= 941001.0 && salarioTotal <= 1381000.0)
            {
                impuestoRenta = salarioTotal * 0.1;
            }
            else if (salarioTotal >= 1381001.0 && salarioTotal <= 2423000.0)
            {
                impuestoRenta = salarioTotal * 0.15;
            }
            else if (salarioTotal >= 2423001.0 && salarioTotal <= 4845000.0)
            {
                impuestoRenta = salarioTotal * 0.2;
            }
            else if (salarioTotal >= 4845001.0)
            {
                impuestoRenta = salarioTotal * 0.25;
            }
            double impuestosTotales = impuestoSSCC + impuestoIVM + impuestoTrabajador + impuestoRenta;
            double salarioNeto = salarioTotal - impuestosTotales;

            lblMensaje.Text = "El salario total es: " + salarioNeto+ ".Donde Se redujo: " + impuestosTotales + ":CCSS: " + impuestoSSCC +
                " ,IVM: "+impuestoIVM+" ,Trabajador: "+impuestoTrabajador+" , Renta: "+impuestoRenta+
                " .Donde: "+salarioExtra+" es Dinero de las Horas Extras Trabajadas";
        }
    }
}