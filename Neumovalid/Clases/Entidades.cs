using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumavalid.Clases
{
    public class Medicion
    {
        public DateTime fechaToma { get; set; }
        public double valorToma { get; set; }

        public Medicion() { }
        public Medicion(DateTime fecha, double valor)
        {
            this.fechaToma=fecha;
            this.valorToma=valor;
        }
    }
    public class Ensayo:Medicion
    {
        public int nroEnsayo { get; set; }
       
        public Ensayo()
        {
           this.fechaToma = DateTime.Now;
        }
        public Ensayo(int ensayo, double valor, DateTime momentoMedicion)
        {
            this.fechaToma = momentoMedicion;
            this.valorToma = valor;
            this.nroEnsayo= ensayo;

        }
        public Ensayo (int ensayo, Medicion medicion)
        {
            this.fechaToma = medicion.fechaToma;
            this.valorToma = medicion.valorToma;
            this.nroEnsayo = ensayo;
        }

    }
}
