using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public Paciente() { }
        public Paciente(string Nombre, string Apellido, string Domicilio, int Telefono, string Email, int Id, int NroHistoriaClinica) : base(Nombre, Apellido, Domicilio, Telefono, Email, Id)
        {
            this.NroHistoriaClinica = NroHistoriaClinica;
        }
        public int NroHistoriaClinica { get; set; }
    }
}
