
namespace biblioteca;

public class Persona
{
    public string Nombre {get;set;}
    public string Apellido {get;set;}
    public Persona(){
        Nombre = "Davis";
    }
    public Persona(string nombre ,string apellido){
        this.Nombre = nombre;
        this.Apellido = apellido;
    } 
}
