
namespace biblioteca.Abstraccion;

public abstract class Figura
{
    public double lado {get;set;}
    public string nombre {get;set;}
    public string camino {get;set;}
    public Figura(double lado ){
        this.lado = lado;
    }
    public Figura(double lado ,string nombre, string camino){
        this.nombre = nombre;
        this.camino = camino;
        this.lado = lado;
    }
    public abstract double CalcularArea();

}
