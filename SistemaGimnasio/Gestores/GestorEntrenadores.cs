using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores
{
    public class GestorEntrenadores
    {
        private List<Entrenador> _entrenadores;

        public GestorEntrenadores()
        {
            _entrenadores = new List<Entrenador>();
        }
        public void CrearRutina(string nombre, string especialidad)
        {
            _entrenadores.Add(new Entrenador(nombre, especialidad));
        }

        public Entrenador BuscarRutina(string nombre)
        {
            return _entrenadores.FirstOrDefault(e => e.Nombre == nombre);
        }
    }
}
