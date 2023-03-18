using System;
using TareaSemana8;
using TareaSemana8.Models;

Producto producto = new Producto();
using (AlmacenContext db = new AlmacenContext())
{
    Console.WriteLine("Por Favor Ingrese el Nombre");
    producto.Nombre = Console.ReadLine();
    Console.WriteLine("Por Favor Ingrese la Descripcion");
    producto.Descripcion = Console.ReadLine();
    Console.WriteLine("Por Favor Ingrese el Precio");
    producto.Precio = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Por Favor Ingrese el Stock");
    producto.Stock = int.Parse(Console.ReadLine());
    db.Add(producto);
    db.SaveChanges();
    Console.WriteLine("¡¡Su Producto Fue Ingresado  Exitosamente!!\n");

    var lista = db.Productos.ToList();
    foreach (var mostrar in lista)
    {
        Console.WriteLine("\nNombre:  " + mostrar.Nombre);
        Console.WriteLine("Descripcion: " + mostrar.Descripcion);
        Console.WriteLine("Precio  " + mostrar.Precio);
        Console.WriteLine("Stock " + mostrar.Stock);
    }

}
