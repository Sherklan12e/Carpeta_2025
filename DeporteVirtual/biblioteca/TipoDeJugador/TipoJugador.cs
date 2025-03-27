
namespace biblioteca;
public interface TipoJugador
{
    public double GetPrecision(Jugador jugador);
    public double GetVisionGeneral(Jugador jugador);
    public void AplicarEntrenamientoFisico(Jugador jugador);
    public void AplicarEntrenamientoLirico(Jugador jugador);
    public void AplicarEntrenamientoTactico(Jugador jugador);
}
