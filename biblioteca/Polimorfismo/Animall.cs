
namespace biblioteca.Polimorfismo;

public class Animall
{
    public string Nombre { get; set; } 
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
    public void Dormir()
    {
        Console.WriteLine($"{Nombre} está durmiendo.");
    }
}
public class Perros : Animall
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra: ¡Guau guau!");
    }
}

public class Gatos : Animall
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maúlla: ¡Miau!");
    }
}
