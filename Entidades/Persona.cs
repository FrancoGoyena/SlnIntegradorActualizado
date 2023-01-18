using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public Persona() { }
        public Persona(string Nombre, string Apellido, string Domicilio, int Telefono, string Email, int Id)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Domicilio = Domicilio;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Id = Id;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

    }
}
