using System;
using System.Collections.Generic;

class Ticket
{
    public string Tipo { get; private set; }
    public double Precio { get; private set; }

    public Ticket(string tipo, double precio)
    {
        Tipo = tipo;
        Precio = precio;
    }
}