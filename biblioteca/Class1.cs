namespace biblioteca;

public class Bolillero : ICloneable
{
    private List<int> bolillasOriginales;
    private Queue<int> bolillasActuales;
    private Random random;

    public Bolillero(int cantidadBolillas)
    {
        bolillasOriginales = Enumerable.Range(0, cantidadBolillas + 1).ToList();
        bolillasActuales = new Queue<int>(bolillasOriginales);
        random = new Random();
    }

    public int SacarBolilla()
    {
        if (bolillasActuales.Count == 0)
            VolverABolillero();

        int index = random.Next(bolillasActuales.Count);
        int bolilla = bolillasActuales.ElementAt(index);
        bolillasActuales = new Queue<int>(bolillasActuales.Where((_, i) => i != index));
        return bolilla;
    }

    public void VolverABolillero()
    {
        bolillasActuales = new Queue<int>(bolillasOriginales);
    }

    public bool Jugar(List<int> jugada)
    {
        VolverABolillero();
        foreach (var numeroEsperado in jugada)
        {
            int bolilla = SacarBolilla();
            if (bolilla != numeroEsperado)
                return false;
        }
        return true;
    }

    public long JugarNVeces(List<int> jugada, long cantidad)
    {
        long aciertos = 0;
        for (int i = 0; i < cantidad; i++)
        {
            if (Jugar(jugada))
                aciertos++;
        }
        return aciertos;
    }

    public object Clone()
    {
        var copia = new Bolillero(0)
        {
            bolillasOriginales = new List<int>(this.bolillasOriginales),
            bolillasActuales = new Queue<int>(this.bolillasActuales),
            random = new Random()
        };
        return copia;
    }
}