
namespace biblioteca.session;

public class SessionTactica : Session
{
     public override void AplicarA(Jugador jugador) => jugador.AplicarEntrenamientoTactico();
}
