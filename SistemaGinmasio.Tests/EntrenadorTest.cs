
using SistemaGimnasio.Modelos;

namespace SistemaGinmasio.Tests
{
    public class EntrenadorTest
    {
        [Fact]
        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var usuario2 = new Usuario("Sebastian", 20, "Aumentar masa muscular");
            var entrenador = new Entrenador("Pepe", "Licuados proteicos");

            //Act
            entrenador.AsignarUsuarios(usuario);
            entrenador.AsignarUsuarios(usuario2);

            //Assert
            Assert.NotEmpty(entrenador.ObtenerUsuariosAsignados());
            Assert.Contains(usuario2, entrenador.ObtenerUsuariosAsignados());

        }
    }
}
