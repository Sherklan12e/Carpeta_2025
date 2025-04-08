using biblioteca;
namespace tests;

public class UnitTest1
{
    private Bolillero bolillero;

    public BolilleroTests()
    {
        bolillero = new Bolillero(10, new Primero());
    }

    [Fact]
    public void SacarBolilla()
    {
        int bolilla = bolillero.SacarBolilla();
        Assert.Equal(0, bolilla);
        Assert.Equal(9, bolillero.CantidadDentro());
        Assert.Equal(1, bolillero.CantidadFuera());
    }

    [Fact]
    public void ReIngresar()
    {
        bolillero.SacarBolilla();
        bolillero.ReIngresar();
        Assert.Equal(10, bolillero.CantidadDentro());
        Assert.Equal(0, bolillero.CantidadFuera());
    }

    [Fact]
    public void JugarGana()
    {
        var jugada = new List<int> { 0, 1, 2, 3 };
        var bolillero = new Bolillero(10, new PrimeroConsecutivo()); // Clase que devuelve 0,1,2,3,...
        Assert.True(bolillero.Jugar(jugada));
    }

    [Fact]
    public void JugarPierde()
    {
        var jugada = new List<int> { 4, 2, 1 };
        Assert.False(bolillero.Jugar(jugada));
    }

    [Fact]
    public void GanarNVeces()
    {
        var jugada = new List<int> { 0, 1 };
        var bolillero = new Bolillero(10, new PrimeroConsecutivo());
        int ganadas = bolillero.JugarNVeces(jugada, 1);
        Assert.Equal(1, ganadas);
    }
}
