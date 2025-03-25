
namespace biblioteca;
public class Jugador
{
    public double Visionjuego {get;set;}
    public double VisionDeComportamiento {get;set;}
    public double Potencia {get;set;}
    public double habilidadPases {get;set;}

    public double GetPrecision(){
        throw new Exception("a");
    }

    public double GetVsionGeneral(){
        throw new Exception("a");
    }
    public void AplicarEntrenamientoFisico(){
        throw new Exception("a");
    }
    public void AplicarEntrenamientoLirico(){
        throw new Exception("a");
    }
    public void AplicarEntrenamientoTactico(){
        throw new Exception("a");
    }


}
