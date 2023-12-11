class Program
{
    static void Main()
    {
        ZooFacade zooFacade = new ZooFacade();

        // Vender algunos tickets a través de la fachada
        zooFacade.VenderTicket("Mayor de edad", 20.0, "Juan");
        zooFacade.VenderTicket("Menor de edad", 10.0, "Ana");

        // Imprimir información a través de la fachada
        zooFacade.ImprimirInformacion();
    }
}