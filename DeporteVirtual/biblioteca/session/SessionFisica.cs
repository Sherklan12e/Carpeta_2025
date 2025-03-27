
namespace biblioteca.session;
public class SessionFisica: Session
{
    public override void AplicarA(Jugador jugador) => jugador.AplicarEntrenamientoFisico();
}
