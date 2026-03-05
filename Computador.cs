
namespace Desafio_Pc_Composicao;

internal class Computador
{
    public Processador Processador;
    public PlacaMae PlacaMae;

    public Computador(Processador processador, PlacaMae placaMae)
    {
        Processador = processador;
        PlacaMae = placaMae;
    }

    public void ExibirConfiguracoes()
    {
        Console.WriteLine("Computador configurado com: ");
        Console.WriteLine($"Processador: {Processador.Marca} - {Processador.Modelo}");
        Console.WriteLine($"Placa mae: {PlacaMae.Fabricante} - {PlacaMae.Socket}");
        
    }
}
