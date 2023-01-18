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
    public static class AdmHabitacion
    {
        private static DBClinicaEFContext context = new DBClinicaEFContext();
        public static List<Habitacion> Listar()
        {
            
            List<Habitacion> ListaHabitaciones = new List<Habitacion>();

            ListaHabitaciones.Add(new Habitacion(1, 10, "ocupada"));
            ListaHabitaciones.Add(new Habitacion(2, 20, "libre"));
            ListaHabitaciones.Add(new Habitacion(3, 30, "ocupada"));
            ListaHabitaciones.Add(new Habitacion(4, 40, "libre"));
            ListaHabitaciones.Add(new Habitacion(5, 50, "ocupada"));
            return context.Habitaciones.ToList();

        }
        public static Habitacion Listar(Habitacion Estado)
        {

            return context.Habitaciones.Find(Estado);
        }
        public static int Insertar(Habitacion habitacion)
        {
            context.Habitaciones.Add(habitacion);
            return context.SaveChanges();
        }
        public static int Eliminar(int id)
        {
            Habitacion habitacionOrigen = context.Habitaciones.Find(id);
            if (habitacionOrigen != null)
            {
                context.Habitaciones.Remove(habitacionOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
        public static Habitacion TraerUno(Habitacion numero)
        {
            return context.Habitaciones.Find(numero);
        }
    }
}
