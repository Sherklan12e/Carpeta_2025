class Motor:
    def __init__(self, tipo):
        self.tipo = tipo 
        
    def encender(self):
        return f"Motor {self.tipo} : Encendido"
    def apagar(self):
        return f"Motor {self.tipo} : Apagado"