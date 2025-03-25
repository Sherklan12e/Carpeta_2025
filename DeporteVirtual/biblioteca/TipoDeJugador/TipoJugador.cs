
namespace biblioteca;
public interface TipoJugador
{
    public double GetPrecision(Jugador jugador);
    public double GetVisionGeneral(Jugador jugador);
    public void AplicarEntrenamientoFisico();
    public void AplicarEntrenamientoLirico();
    public void AplicarEntrenamientoTactico();
}
