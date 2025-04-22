namespace tests;

using biblioteca;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Tests
{
    private Bolillero _bolillero;

    public Tests()
    {
        _bolillero = new Bolillero(10, new Primero());
    }

    public async Task SacarBolilla()
    {
        int bolilla = _bolillero.SacarBolilla();
        Console.WriteLine($"Bolilla sacada: {bolilla}"); // Debería ser 0
        Console.WriteLine($"Adentro: {_bolillero.CantidadAdentro}, Afuera: {_bolillero.CantidadAfuera}");
    }

    public async Task ReIngresar()
    {
        _bolillero.SacarBolilla();
        _bolillero.ReIngresar();
        Console.WriteLine($"Reingresadas. Adentro: {_bolillero.CantidadAdentro}, Afuera: {_bolillero.CantidadAfuera}");
    }

    public async Task JugarGana()
    {
        var jugada = new List<int> { 0, 1, 2, 3 };
        bool resultado = await _bolillero.Jugar(jugada);
        Console.WriteLine($"¿Ganó? {resultado}"); // Debería ser true
    }

    public async Task JugarPierde()
    {
        var jugada = new List<int> { 4, 2, 1 };
        bool resultado = await _bolillero.Jugar(jugada);
        Console.WriteLine($"¿Ganó? {resultado}"); // Debería ser false
    }

    public async Task GanarNVeces()
    {
        var jugada = new List<int> { 0, 1 };
        int ganadas = await _bolillero.JugarNVeces(jugada, 1);
        Console.WriteLine($"Ganadas: {ganadas}"); // Debería ser 1
    }
}
