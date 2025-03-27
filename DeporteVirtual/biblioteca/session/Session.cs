
namespace biblioteca.session;

public class Session
{
    public string Nombre { get; set; }
    public abstract void AplicarA(Jugador jugador);
}