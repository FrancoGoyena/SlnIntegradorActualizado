using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using Datos.Data;

namespace Negocio
{
    public static class AdmMedico
    {
        private static DBClinicaEFContext context = new DBClinicaEFContext();
        public static List<Medico> Listar()
        {
            List<Medico> ListaMedicos = new List<Medico>();

            ListaMedicos.Add(new Medico("Juan", "Pérez", "San Juan 100", 11111, "juanmedico@gmail.com", 1, 100, "Clinico"));
            ListaMedicos.Add(new Medico("Pablo", "González", "San Juan 200", 22222, "pablomedico@gmail.com", 2, 200, "Clinico"));
            ListaMedicos.Add(new Medico("Pedro", "Gutiérrez", "San Juan 300", 33333, "pedromedico@gmail.com", 3, 300, "Pediatra"));
            ListaMedicos.Add(new Medico("Marco", "Martínez", "San Juan 400", 44444, "marcomedico@gmail.com", 4, 400, "Pediatra"));
            ListaMedicos.Add(new Medico("Javier", "Álvarez", "San Juan 500", 55555, "javiermedico@gmail.com", 5, 500, "Traumatologo"));

            return context.Medicos.ToList();
        }
        public static Medico Listar(string Especialidad)
        {
            return context.Medicos.Find(Especialidad);
        }
        public static int Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();
        }
        public static int Eliminar(int id)
        {
            Medico medicoOrigen = context.Medicos.Find(id);
            if (medicoOrigen != null)
            {
                context.Medicos.Remove(medicoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
        public static Medico TraerUno(int id)
        {
            return context.Medicos.Find(id);
        }
    }
}
