using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCP1BC9.Clases
{
    public class ClsImc
    {
        private const double KG = 2.2046;
        public String Nombre { get; set; }
        public int edad { get; set; }
        public int altura { get; set; }

        public char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }


        public String prueba()
        {
            Nombre = "Darwin";
            edad = 20;
            altura = 173;
            sexo = 'F';
            peso = 157;


            double pesoKG = this.peso / KG;
            double estaturaMts = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMts, 2));
            imc = pesoKG / altu;
            return this.imc.ToString();

        }


        public override string ToString()
        {
            String retorno = $"Altura={altura} \n peso={peso} imc {imc}";
            return retorno;
        }


    }
}