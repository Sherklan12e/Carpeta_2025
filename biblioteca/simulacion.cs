namespace biblioteca;
public static class Simulacion
{
    public static long SimularSinHilos(Bolillero bolillero, List<int> jugada, long cantidad)
    {
        return bolillero.JugarNVeces(jugada, cantidad);
    }

    public static long SimularConHilos(Bolillero bolillero, List<int> jugada, long cantidadTotal, int cantidadHilos)
    {
        var tareas = new List<Task<long>>();
        long simulacionesPorHilo = cantidadTotal / cantidadHilos;

        for (int i = 0; i < cantidadHilos; i++)
        {
            // Clonamos el bolillero para este hilo
            var bolilleroClonado = (Bolillero)bolillero.Clone();

            var tarea = Task.Run(() =>
            {
                return bolilleroClonado.JugarNVeces(jugada, simulacionesPorHilo);
            });

            tareas.Add(tarea);
        }

        Task.WaitAll(tareas.ToArray());

        long totalAciertos = 0;
        foreach (var t in tareas)
        {
            totalAciertos += t.Result;
        }

        return totalAciertos;
    }
}