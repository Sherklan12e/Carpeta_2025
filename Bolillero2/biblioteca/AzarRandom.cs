
namespace biblioteca;
public class AzarRandom : IAzar
{
    public Random random = new Random();

    public int ObtenerSiguiente(int maximo)
    {
        return random.Next(maximo);
    }
}
