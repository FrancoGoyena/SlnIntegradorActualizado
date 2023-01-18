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
    public static class AdmPaciente
    {
        private static DBClinicaEFContext context = new DBClinicaEFContext();
        public static List<Paciente> Listar()
        {
            List<Paciente> ListaPacientes = new List<Paciente>();

            ListaPacientes.Add(new Paciente("Facundo", "Romero", "San Juan 600", 66666, "facundopaciente@gmail.com", 6, 1000));
            ListaPacientes.Add(new Paciente("Matias", "Espinoza", "San Juan 700", 77777, "matiaspaciente@gmail.com", 7, 2000));
            ListaPacientes.Add(new Paciente("Leonel", "Fernández", "San Juan 800", 88888, "leonelpaciente@gmail.com", 8, 3000));
            ListaPacientes.Add(new Paciente("Julian", "Guerrero", "San Juan 900", 99999, "julianpaciente@gmail.com", 9, 4000));
            ListaPacientes.Add(new Paciente("Franco", "Díaz", "San Juan 1000", 00000, "francopaciente@gmail.com", 10, 5000));

            return context.Pacientes.ToList();
        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return context.SaveChanges();
        }

        public static int Eliminar(int id)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(id);
            if (pacienteOrigen != null)
            {
                context.Pacientes.Remove(pacienteOrigen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            return context.Pacientes.Find(nroHistoriaClinica);
        }

    }
}
