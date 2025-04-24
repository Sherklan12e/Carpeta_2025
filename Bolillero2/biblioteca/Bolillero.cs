namespace biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Bolillero
{
    private List<int> _adentro;
    private List<int> _afuera;
    private IAzar _azar;

    public Bolillero(int cantidad, IAzar azar)
    {
        _azar = azar;
        _adentro = Enumerable.Range(0, cantidad).ToList();
        _afuera = new List<int>();
    }

    public int SacarBolilla()
    {
        int indice = _azar.ObtenerSiguiente(_adentro.Count);
        int bolilla = _adentro[indice];
        _adentro.RemoveAt(indice);
        _afuera.Add(bolilla);
        return bolilla;
    }

    public void ReIngresar()
    {
        _adentro.AddRange(_afuera);
        _afuera.Clear();
    }

    public async Task<bool> Jugar(List<int> jugada)
    {
        ReIngresar();
        bool resultado = true;

        foreach (var numero in jugada)
        {
            int bolilla = SacarBolilla();
            if (bolilla != numero)
            {
                resultado = false;
                break;
            }
        }

        return await Task.FromResult(resultado);
    }

    public async Task<int> JugarNVeces(List<int> jugada, int veces)
    {
        int ganadas = 0;

        for (int i = 0; i < veces; i++)
        {
            bool gano = await Jugar(jugada);
            if (gano) ganadas++;
        }

        return ganadas;
    }

    public int CantidadAdentro => _adentro.Count;
    public int CantidadAfuera => _afuera.Count;
}
