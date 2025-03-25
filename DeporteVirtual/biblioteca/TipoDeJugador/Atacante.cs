
namespace biblioteca;

public class Atacante: TipoJugador
{
    public double anotacion {get;set;}
    

    public double GetPrecision(Jugador jugador){
        return 2;
    }

    public double GetVisionGeneral(Jugador jugador){
        return 2;
    }
    public void AplicarEntrenamientoFisico(){

    }
    public void AplicarEntrenamientoLirico(){
        
    }
    public void AplicarEntrenamientoTactico(){
        
    }
}
