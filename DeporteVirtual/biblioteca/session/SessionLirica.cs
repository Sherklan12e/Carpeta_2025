
namespace biblioteca.session;


public class SessionLirica: Session
{
    public override void AplicarA(Jugador jugador) => jugador.AplicarEntrenamientoLirico();
}