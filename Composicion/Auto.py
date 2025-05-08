from .Motor import Motor

class Auto:
    def __init__(self, marca , tipo_motor):
        self.marca = marca
        self.motor = Motor(tipo_motor)
        
    def arrancar(self):
        return f"{self.marca} : {self.motor.encender()}"
    def parar(self):
        return f"{self.marca} : {self.motor.apagar()}"
        