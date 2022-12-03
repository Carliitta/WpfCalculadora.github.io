using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCalculadora
{
    class ClaseCalculadora
    {
        public decimal valor1 { get; set; }
        public decimal valor2 { get; set; }
        public decimal resultado { get; set; }
        public string operacion { get; set; }

        public void mioperacion()
        {
            if (operacion == "Suma")
            {
                resultado = valor1 + valor2;
            }
            if (operacion == "Resta")
            {
                resultado = valor1 - valor2;
            }
            if (operacion == "Multiplicacion")
            {
                resultado = valor1 * valor2;
            }
            if (operacion == "Division")
            {
                resultado = valor1 / valor2;
            }

        }
    }

}
