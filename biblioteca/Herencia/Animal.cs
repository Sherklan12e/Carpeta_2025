
namespace biblioteca.Herencia;
public class Animal
{
    public string Nombre {get;set;}
    public void Dormir(){
        Console.WriteLine($"{Nombre} está durmiendo.");
    }
}
