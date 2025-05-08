
namespace biblioteca.Emcapsulamiento;
public class Personas
{

    private int edad;
    public int Edad {
        get {return 0;}
        set {
            if(value < 0) {
                Console.WriteLine("La edad no puede ser negativa.");
            } else {
                this.edad = value;
            }
        }
    }
}
