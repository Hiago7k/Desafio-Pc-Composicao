
namespace Desafio_Pc_Composicao;

internal class Computador
{
    public Processador cpu;
    public PlacaMae mobo;


    public void ExibirConfiguracoes()
    {
        Console.WriteLine("Computador configurado com: ");
        Console.WriteLine(cpu);
        Console.WriteLine(mobo);
    }
}
