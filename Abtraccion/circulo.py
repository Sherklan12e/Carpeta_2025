import math
from .figura import Figura

class circulo(Figura):
    def __init__(self, nombre,radio):
        super().__init__(nombre)
        self.radio = radio
    def area(self):
        return math.pi * self.radio ** 2
    