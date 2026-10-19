using Xunit;
using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGinmasio.Tests
{
    public class AsignadorRutinasTest
    {
        [Fact]
        public void AsignarRutinaAlUsuario_DebeAsignarCorrectamente()
        {
            //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("YoPuedo", 120);
            var asingador = new AsignadorRutinasTest();

            //Act
            asingador.AsignarRutinaAlUsuario(usuario, rutina);

            //Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]
        public void AsignarUsurioAEntrenador_DebeIncluirUsuario()
        {
            //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var entrenador = new Entrenador("Pepe","LicuadosProteicos");
            var asingador = new AsignadorRutinasTest();

            //Act
            asingador.AsignarUsuarioAEntrenador(usuario, entrenador);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
