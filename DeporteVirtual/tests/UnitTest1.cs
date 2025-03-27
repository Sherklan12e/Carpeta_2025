using biblioteca;
namespace tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var jugador = new Jugador();
    }
    [Fact]
    public void PotenciaJugador()
    {
        var jugador = new Jugador();
        jugador.TipoJugador = new TipoJugador.AplicarEntrenamientoFisico(jugador);

        Assert.NotEqual(1,jugador.Potencia);

    }
}




