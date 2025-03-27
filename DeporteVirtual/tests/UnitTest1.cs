
using biblioteca;
public class EquipoTests
{
    [Fact]
    public void Equipo_CalculaPotencia_Correctamente()
    {
        var equipo = new Equipo
        {
            Jugadores = new List<Jugador>
            {
                new Jugador { Potencia = 50 },
                new Jugador { Potencia = 30 },
                new Jugador { Potencia = 20 }
            }
        };
        double potencia = equipo.GetPotencia();
        Assert.Equal(80, potencia);
    }

    [Fact]
    public void Equipo_CalculaPrecision_Correctamente()
    {
        var jugador1 = new Jugador { HabilidadPases = 10, TipoJugador = new Defensor { Quite = 5 } };
        var jugador2 = new Jugador { HabilidadPases = 8, TipoJugador = new Atacante { Anotacion = 7 } };
        var equipo = new Equipo { Jugadores = new List<Jugador> { jugador1, jugador2 } };

        double precision = equipo.GetPrecision();

        Assert.Equal((3 * 5 + 10) + (3 * 7 + 8), precision);
    }

    [Fact]
    public void Equipo_CalculaVision_Correctamente()
    {
        var jugador1 = new Jugador { VisionJuego = 5, VisionCompaneros = 10, TipoJugador = new Defensor() };
        var jugador2 = new Jugador { VisionJuego = 8, VisionCompaneros = 7, TipoJugador = new Atacante() };
        var equipo = new Equipo { Jugadores = new List<Jugador> { jugador1, jugador2 } };
        double vision = equipo.GetVision();
        Assert.Equal((5 + 10) + (8 + 7), vision);
    }

    [Fact]
    public void Jugador_AplicaEntrenamientoFisico_Correctamente()
    {
        var jugador = new Jugador { Potencia = 10, TipoJugador = new Defensor { Quite = 3 } };

 
        jugador.AplicarEntrenamientoFisico();


        Assert.Equal(11, jugador.Potencia);
        Assert.Equal(3.5, ((Defensor)jugador.TipoJugador).Quite);
    }

    [Fact]
    public void Jugador_AplicaEntrenamientoLirico_Correctamente()
    {
       
        var jugador = new Jugador { HabilidadPases = 5, VisionJuego = 2, TipoJugador = new Atacante { Anotacion = 4 } };

       
        jugador.AplicarEntrenamientoLirico();

   
        Assert.Equal(6, jugador.HabilidadPases);
        Assert.Equal(4.5, ((Atacante)jugador.TipoJugador).Anotacion);
    }

    [Fact]
    public void Equipo_AplicaEntrenamiento_Correctamente()
    {
      
        var jugador1 = new Jugador { Potencia = 10, TipoJugador = new Defensor { Quite = 2 } };
        var jugador2 = new Jugador { Potencia = 15, TipoJugador = new Atacante { Anotacion = 5 } };
        var equipo = new Equipo
        {
            Jugadores = new List<Jugador> { jugador1, jugador2 },
            SesionesEntrenamiento = new List<Sesion> { new SesionFisica() }
        };
        equipo.Entrenar();

        
        Assert.Equal(11, jugador1.Potencia);
        Assert.Equal(16, jugador2.Potencia);
    }
}
