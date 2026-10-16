using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Servicios
{
    internal class AsignadorDeRutinas
    {
        public void AsignarRutinaAlUsuario(Usuario usuario,Rutina rutina)
        {
            usuario.AsignarRutina(rutina);
        }
        public void AsignarUsuarioAEntrenador(Usuario usuario, Entrenador entrenador)
        {
            entrenador.AsignarUsuarios(usuario);
        }
    }
}
