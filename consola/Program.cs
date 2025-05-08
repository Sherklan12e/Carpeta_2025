using biblioteca;
using biblioteca.Abstraccion;
using biblioteca.Emcapsulamiento;
using biblioteca.Herencia;
using biblioteca.Interfaz;
using biblioteca.Polimorfismo;

// Bolillero bolillero = new Bolillero(10); // bolillas del 0 al 10
// List<int> jugada = new List<int> { 3, 7, 1 };

// long sinHilos = Simulacion.SimularSinHilos(bolillero, jugada, 10000);
// Console.WriteLine($"Simulación sin hilos - Aciertos: {sinHilos}");

// long conHilos = Simulacion.SimularConHilos(bolillero, jugada, 10000, 4);
// Console.WriteLine($"Simulación con hilos - Aciertos: {conHilos}");


// Persona p1 = new Persona();
// Persona p2 = new Persona("Juan","mendez");

// Console.WriteLine(p1.Nombre);
// Console.WriteLine(p2.Nombre);

// Cuadrado cuadrado = new Cuadrado(34,"juan","camino 2","rojo");
// Cuadrado cuadradoReal = (Cuadrado)cuadrado;
// Console.WriteLine(cuadrado.CalcularArea());
// Console.WriteLine(cuadrado.lado);
// cuadrado.MostrarColor();
// Personas davis = new Personas();
// davis.Edad = 25;
// Console.WriteLine(davis.Edad); // 25
// IAnimal perro = new Perro();
// perro.HacerSonido();

// Animal animla = new Animal();
// animla.Nombre = "Perro";
// animla.Dormir();

Animall perro = new Perros();
perro.Nombre = "Firulais";
perro.HacerSonido(); // El perro ladra: ¡Guau guau!
Animall a = new Animall();
a.Nombre = "Gato";
a.HacerSonido(); // El animal hace un sonido.