class Zoo
{
    private List<Ticket> ticketsVendidos;
    private List<Visitante> visitantesDelDia;

    public Zoo()
    {
        ticketsVendidos = new List<Ticket>();
        visitantesDelDia = new List<Visitante>();
    }

    public void VenderTicket(Ticket ticket, Visitante visitante)
    {
        ticketsVendidos.Add(ticket);
        visitantesDelDia.Add(visitante);

        Console.WriteLine($"Se ha vendido un ticket {ticket.Tipo} a {visitante.Nombre} por ${ticket.Precio}");
    }

    public void ImprimirTicketsVendidos()
    {
        Console.WriteLine("\nTickets Vendidos:");
        foreach (var ticket in ticketsVendidos)
        {
            Console.WriteLine($"{ticket.Tipo} - ${ticket.Precio}");
        }
    }

    public void ImprimirVisitantesDelDia()
    {
        Console.WriteLine("\nVisitantes del Día:");
        foreach (var visitante in visitantesDelDia)
        {
            Console.WriteLine(visitante.Nombre);
        }
    }
}