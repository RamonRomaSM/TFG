import AccesoBdd


class Producto:
    nombre = ''
    precio = 0
    imagen = ''
    supermercado = ''
    URL = ''
    oferta = '' #si no esta en oferta qui pondra 'no'


    def __init__(self,nombre,precio,imagen,supermercado,URL,oferta):
        self.nombre=nombre

        self.URL = str(URL)
        self.precio = str(precio)
        self.oferta = str(oferta)
        self.imagen = str(imagen)
        self.supermercado = str(supermercado)


    def guardarEnBdd(self):
        AccesoBdd.guardarProducto(self)

