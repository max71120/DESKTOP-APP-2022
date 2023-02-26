using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
     public class CalcularPrecio
    {
        private int horasRequeridas;

        public int HorasRequeridas { get; set; }

        //Metodo para calcular el precio de horas de vuelo
        public decimal CalculaPrecio(int horasReq, decimal valorHora)
        {
            decimal PrecioTotal = horasReq * valorHora;
            return PrecioTotal ;
        }

    }
}
