
namespace biblioteca.session;

public abstract class  Session
{
    public string Nombre { get; set; }
    public abstract void AplicarA(Jugador jugador);
} 