using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LaVeloz.Logica
{
    public class GestorPasajeros
    {
        private List<Pasajero> pasajeros;
        private string archivo = "pasajeros.txt";

        public GestorPasajeros()
        {
            pasajeros = new List<Pasajero>();
            CargarPasajeros();
        }

        public void AgregarPasajero(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
            GuardarPasajeros();
        }

        public List<Pasajero> ObtenerPasajeros()
        {
            return pasajeros;
        }

        public bool EliminarPasajero(string dni)
        {
            Pasajero pasajero = pasajeros.FirstOrDefault(
                p => p.DNI == dni
            );

            if (pasajero == null)
                return false;

            pasajeros.Remove(pasajero);
            GuardarPasajeros();

            return true;
        }

        public bool ModificarPasajero(
            string dni,
            string nuevoNombre,
            string nuevoDestino)
        {
            Pasajero pasajero = pasajeros.FirstOrDefault(
                p => p.DNI == dni
            );

            if (pasajero == null)
                return false;

            pasajero.Nombre = nuevoNombre;
            pasajero.Destino = nuevoDestino;

            GuardarPasajeros();

            return true;
        }

        private void GuardarPasajeros()
        {
            using (StreamWriter escritor = new StreamWriter(archivo))
            {
                foreach (Pasajero p in pasajeros)
                {
                    escritor.WriteLine(
                        p.DNI + "|" + p.Nombre + "|" + p.Destino
                    );
                }
            }
        }

        private void CargarPasajeros()
        {
            if (!File.Exists(archivo))
                return;

            foreach (string linea in File.ReadAllLines(archivo))
            {
                string[] datos = linea.Split('|');

                if (datos.Length == 3)
                {
                    pasajeros.Add(new Pasajero(
                        datos[0],
                        datos[1],
                        datos[2]
                    ));
                }
            }
        }
    }
}