
namespace biblioteca;
public class Jugador
{
   public double VisionJuego { get; set; }
    public double VisionCompaneros { get; set; }
    public double Potencia { get; set; }
    public double HabilidadPases { get; set; }
    public TipoJugador TipoJugador { get; set; }

    public double GetPrecision() => TipoJugador.GetPrecision(this);
    public double GetVisionGeneral() => TipoJugador.GetVisionGeneral(this);

    public void AplicarEntrenamientoFisico() => TipoJugador.AplicarEntrenamientoFisico(this);
    public void AplicarEntrenamientoLirico() => TipoJugador.AplicarEntrenamientoLirico(this);
    public void AplicarEntrenamientoTactico() => TipoJugador.AplicarEntrenamientoTactico(this);


}
