using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public Habitacion() { }
        public Habitacion(int Id, int Numero, string Estado)
        {

            this.Id = Id;
            this.Numero = Numero;
            this.Estado = Estado;
        }
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }

    }
}
