namespace LaVeloz.Logica
{
    public class Pasajero
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Destino { get; set; }

        public Pasajero(string dni, string nombre, string destino)
        {
            DNI = dni;
            Nombre = nombre;
            Destino = destino;
        }
    }
}