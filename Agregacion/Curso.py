class Curso:
    def __init__(self, nombre):
        self.nombre = nombre
        self.estudiantes = []
        
    def agregar_estudiantes(self, estudiantes):
        self.estudiantes.append(estudiantes)
        
    def lista_estudiantes(self):
        return [str(e) for e in self.estudiantes]
    
    
    