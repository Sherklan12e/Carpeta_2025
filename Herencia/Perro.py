from .Animal import Animal
class Perro(Animal):
    
    def __init__(self, nombre):
        self.nombre = nombre
    
    def hablar(self):
        return f"{self.nombre} dice: Guau! Guau!"