from Herencia import Perro
from Abtraccion import circulo
from Composicion import Auto
from Agregacion import Estudiantes
from Agregacion import Curso
from Encapsulamiento import CuentaBancaria
# perro1 = Perro("Kira")
# print(perro1.hablar())

# circulo1 = circulo("davis", 23)
# print(circulo1.area())

# auto1 = Auto("Lanux", "C323")
# print(auto1.arrancar())
# liss = ["solo", "silla", "parjaro", "local"]
# estudiante1 = Estudiantes("Davis")

# print(repr(estudiante1))

# curso1 = Curso("PrimeroA")
# curso1.agregar_estudiantes(estudiante1)

# curso1.lista_estudiantes()
# print(curso1.lista_estudiantes())

cuenta1 = CuentaBancaria("pedro",2000)
print(cuenta1())
print(cuenta1.mostrarinfo())
print(cuenta1.depositar(200))
print(cuenta1.mostrarinfo())
print(cuenta1.retirar(3000))