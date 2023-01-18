using Datos.Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public static class DacMedico
    {
        private static DBClinicaEFContext context = new DBClinicaEFContext();
        public static List<Medico> Select()
        {
            return context.Medicos.ToList();
        }

        public static Medico Select(string especialidad)
        {
            return context.Medicos.Find(especialidad);
        }

        public static int Insert(Medico medico)
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
        public static Medico SelectById(int id)
        {
            return context.Medicos.Find(id);
        }

    }
}
