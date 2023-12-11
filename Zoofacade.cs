class ZooFacade
{
    private Zoo zoo;

    public ZooFacade()
    {
        zoo = new Zoo();
    }

    public void VenderTicket(string tipo, double precio, string nombreVisitante)
    {
        Ticket ticket = new Ticket(tipo, precio);
        Visitante visitante = new Visitante(nombreVisitante);

        zoo.VenderTicket(ticket, visitante);
    }

    public void ImprimirInformacion()
    {
        zoo.ImprimirTicketsVendidos();
        zoo.ImprimirVisitantesDelDia();
    }
}