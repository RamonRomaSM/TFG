import mysql.connector

mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    password="nosequeponer"
)

def borrarBdd():

    mycursor = mydb.cursor()

    mycursor.execute("TRUNCATE TABLE tfg.productos")

    print("[SISTEMA] Base de datos borrada")

def guardarProducto(Producto):
    mycursor = mydb.cursor()

    sql = "INSERT INTO tfg.productos (idproductos, nombre, precio, supermercado, oferta, url, imagen) VALUES (%s, %s, %s, %s, %s, %s, %s)"
    val = (Producto.id, Producto.nombre, Producto.precio, Producto.supermercado, Producto.oferta, Producto.URL, Producto.imagen)
    mycursor.execute(sql, val)

    mydb.commit()
    print('[SISTEMA] producto guardado:    ' + Producto.nombre + '  :  ' + Producto.precio + '  :  ' + Producto.URL + '  :  ' + Producto.imagen + '  :  ' + Producto.oferta + '  :  ' + Producto.supermercado)