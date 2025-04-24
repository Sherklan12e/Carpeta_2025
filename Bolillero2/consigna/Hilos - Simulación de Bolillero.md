# Simulación de Bolillero 
Dominio  ![](Aspose.Words.b28d022f-d64d-4c4e-b714-71ed350ef643.001.png)

Se pide hacer un programa para simular el funcionamiento  de  bolilleros  y  nos  comentan  el  dominio  de  la siguiente  forma.  El  bolillero  tiene  una  determinada  cantidad  de  bolillas numeradas(de cero a N) y de este se espera poder  sacar una bolilla (con el efecto de lado correspondiente).  El bolillero admite una Jugada, que es una lista de bolillas y  el bolillero debe de indicar si la jugada fue acertada o no  (es decir, empieza a sacar bolillas y si todas matchean en  orden con la jugada, entonces gano).  

Este  bolillero  también  admite  jugarNVeces,  recibiendo  por  parámetro  una  lista  de bolillas y una cantidad de veces a jugar, devolviendo la cantidad de veces que la lista de bolillas fue acertada. 

También se debe de poder volver a colocar en el bolillero, las bolillas sacadas. 

Para  las  bolillas  sacadas al azar, se recomienda crear una interfaz que pueda sacar números aleatorios con una clase que la implemente usando la clase Random 

Test de Unidad 

- El test debe tener un atributo del tipo Bolillero y en el constructor crearlo con 10 bolillas (del 0 al 9) y setear el azar del bolillero con la clase de prueba *Primero*. 
- Test method SacarBolilla 
  - Verificar que devuelve la bolilla 0 (cero). 
  - Después, verificar que dentro del bolillero hay 9 bolillas. 
  - Verificar que afuera del bolillero hay una bolilla. 
- Test method ReIngresar: Se tiene que sacar una bolilla y después correr el método de reingresar bolillas. 
  - Verificar que dentro del bolillero hay 10 bolillas. 
  - Verificar que fuera del bolillero no hay ninguna bolilla. 
- Test method JugarGana: Se tiene que jugar con {0,1,2,3} y verificar que se ganó en todos los casos, [EJEMPLOS](https://github.com/ET12DE1Computacion/RepasoPersona/blob/14bcc5041f1adbe6566bfcbdfd645019f438f7c0/RepasoPersona.Test/PersonaTest.cs#L30). 
- Test method JugarPierde: Se tiene que jugar con {4, 2, 1} y verificar que no se ganó. 
- Test method GanarNVeces: con la jugada {0, 1} se tiene que jugar 1 vez y verificar que se ganó 1 vez (hacerlo con fact, no hace falta usar *Theory* e *InlineData*). 
