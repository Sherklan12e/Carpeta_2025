using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Bolillero
    {
        private IAzar azar;
    private List<int> dentro;
    private List<int> fuera;

    public Bolillero(int cantidad, IAzar azar)
    {
        this.azar = azar;
        dentro = Enumerable.Range(0, cantidad).ToList();
        fuera = new List<int>();
    }

    public int SacarBolilla()
    {
        int indice = azar.ObtenerSiguiente(dentro.Count);
        int bolilla = dentro[indice];
        dentro.RemoveAt(indice);
        fuera.Add(bolilla);
        return bolilla;
    }

    public void ReIngresar()
    {
        dentro.AddRange(fuera);
        fuera.Clear();
    }

    public bool Jugar(List<int> jugada)
    {
        ReIngresar();
        foreach (var esperado in jugada)
        {
            var bolilla = SacarBolilla();
            if (bolilla != esperado)
                return false;
        }
        return true;
    }

    public int JugarNVeces(List<int> jugada, int veces)
    {
        int ganadas = 0;
        for (int i = 0; i < veces; i++)
        {
            if (Jugar(jugada))
                ganadas++;
        }
        return ganadas;
    }

    public int CantidadDentro() => dentro.Count;
    public int CantidadFuera() => fuera.Count;
    }
}