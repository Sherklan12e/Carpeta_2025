class CuentaBancaria:
    def __init__(self, titular , saldo_iniciar):
        self.titular = titular
        self.__saldo = saldo_iniciar
        
    def depositar(self, monto):
        if monto > 0:
            self.__saldo += monto
            return f"Deposito exitoso. Nuevo saldo: {self.__saldo}"
        return "El monto debe de ser positivo"
    def retirar(self, monto):
        if 0 < monto <= self.__saldo:
            self.__saldo -= monto
            return f"Retiro exitoso. Nuevo saldo: {self.__saldo}"
        return "Fondos insuficientes o monto invalido"
    
    def mostrarinfo(self):
        return f"Saldo de {self.titular} : {self.__saldo}"
    
    def __call__(self):
        return f"{self.titular}"
    
    
    def __str__(self):
        return f"{self.titular}"
    