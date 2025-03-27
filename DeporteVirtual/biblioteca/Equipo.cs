
using biblioteca.session;

namespace biblioteca;
public class Equipo
{
   public List<Jugador> Jugadores { get; set; } = new List<Jugador>();
    public List<Sesion> SesionesEntrenamiento { get; set; } = new List<Sesion>();

    public void Entrenar()
    {
        foreach (var sesion in SesionesEntrenamiento)
        {
            foreach (var jugador in Jugadores)
            {
                sesion.AplicarA(jugador);
            }
        }
    }

    public double GetPotencia()
    {
        return Jugadores
            .OrderByDescending(j => j.Potencia)
            .Take(2)
            .Sum(j => j.Potencia);
    }

    public double GetPrecision()
    {
        return Jugadores
            .Sum(j => (3 * j.GetPrecision()) + j.HabilidadPases);
    }

    public double GetVision()
    {
        return Jugadores
            .Sum(j => j.GetVisionGeneral());
    }
}
