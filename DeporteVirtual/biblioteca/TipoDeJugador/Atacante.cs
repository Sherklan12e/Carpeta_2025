
namespace biblioteca;

public class Atacante: TipoJugador
{
    public double Anotacion { get; set; }

    public double GetPrecision(Jugador jugador) => Anotacion;
    public double GetVisionGeneral(Jugador jugador) => jugador.VisionJuego + jugador.HabilidadPases;

    public void AplicarEntrenamientoFisico(Jugador jugador)
    {
        jugador.Potencia += 1;
        jugador.HabilidadPases += 0.5;
    }

    public void AplicarEntrenamientoLirico(Jugador jugador)
    {
        jugador.HabilidadPases += 1;
        Anotacion += 0.5;
    }

    public void AplicarEntrenamientoTactico(Jugador jugador)
    {
        jugador.HabilidadPases += 0.5;
        jugador.VisionJuego += 0.5;
        jugador.VisionCompaneros += 0.5;
    }
}
