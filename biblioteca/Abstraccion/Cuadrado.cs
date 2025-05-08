
namespace biblioteca.Abstraccion;

public class Cuadrado : Figura
{
    
    public string Color { get ; set; }

    public Cuadrado(double lado): base(lado){
        
    }
    public Cuadrado(double lado , string N , string camino, string color ): base(lado,N,camino) {

        this.Color = color;
    }   
    public override double CalcularArea()
    {
        return lado * lado;
    }
    public void MostrarColor(){
        Console.WriteLine($"El color del cuadrado es {Color}");
    }
}
