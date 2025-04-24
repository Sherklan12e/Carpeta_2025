namespace tests;

using biblioteca;
using Xunit;
using System.Collections.Generic;
using System.Threading.Tasks;


public class BolilleroTest
{
    private readonly Bolillero _bolillero;

    public BolilleroTest()
    {
        _bolillero = new Bolillero(10, new Primero());
    }

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = _bolillero.SacarBolilla();

        Assert.Equal(0, bolilla);
        Assert.Equal(9, _bolillero.CantidadAdentro);
        Assert.Equal(1, _bolillero.CantidadAfuera);
    }

    [Fact]
    public void ReIngresar()
    {
        _bolillero.SacarBolilla();
        _bolillero.ReIngresar();

        Assert.Equal(10, _bolillero.CantidadAdentro);
        Assert.Equal(0, _bolillero.CantidadAfuera);
    }

    [Fact]
    public async Task JugarGana()
    {
        var jugada = new List<int> { 0, 1, 2, 3 };
        var gano = await _bolillero.Jugar(jugada);

        Assert.True(gano);
    }

    [Fact]
    public async Task JugarPierde()
    {
        var jugada = new List<int> { 4, 2, 1 };
        var gano = await _bolillero.Jugar(jugada);

        Assert.False(gano);
    }

    [Fact]
    public async Task GanarNVeces()
    {
        var jugada = new List<int> { 0, 1 };
        var ganadas = await _bolillero.JugarNVeces(jugada, 1);

        Assert.Equal(1, ganadas);
    }
}

