using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904ASP.Models
{
    public class Cinepolis
    {
        public string nombre { get; set; }
        public int cantidad_compradores { get; set; }
        public bool tarjeta_cineco { get; set; }
        public int cantidad_boletas { get; set; }
        public double total_pagar { get; set; }
        public string alerta { get; set; }

        public void Valor_Pagar()
        {
            double precio_boleta = 12;
            int limite_boletas = this.cantidad_compradores * 7;
            this.alerta = "";

            if (this.cantidad_boletas > limite_boletas) 
            {
                this.alerta = "No se puede comprar mas de 7 boletas por persona";
                this.total_pagar = 0;
                return;
            }

            this.alerta = "";
            double subtotal = this.cantidad_boletas * precio_boleta;
            double descuento = 0;


            if (this.cantidad_boletas > 5)
            {
                descuento = subtotal * 0.15;
            } else if (this.cantidad_boletas >= 3 && this.cantidad_boletas <= 5)
            {
                descuento = subtotal * 0.10;
            } else
            {
                descuento = 0;
            }

            this.total_pagar = subtotal - descuento;

            if (this.tarjeta_cineco == true)
            {
                double descuento_cineco = this.total_pagar * 0.10;
                this.total_pagar = this.total_pagar - descuento_cineco;
            }
        }
    }
}