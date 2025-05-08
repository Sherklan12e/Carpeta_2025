```python
class Saludo:
    def __init__(self, nombre):
        self.nombre = nombre

    def __call__(self):
        return f"Hola, {self.nombre}!"

# Uso:
s = Saludo("Lucía")
print(s())  # Hola, Lucía!
```
```python
class Curso:
    def __init__(self, nombre, alumnos):
        self.nombre = nombre
        self.alumnos = alumnos

    def __contains__(self, alumno):
        return alumno in self.alumnos

# Uso:
curso = Curso("Python", ["Ana", "Luis", "Sofía"])
print("Luis" in curso)  # True
print("Carlos" in curso)  # False
```             