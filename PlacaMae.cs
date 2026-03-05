namespace Desafio_Pc_Composicao;

internal class PlacaMae
{
    public PlacaMae(string fabricante, string socket)
    {
        Fabricante = fabricante;
        Socket = socket;
    }

    public string Fabricante { get;  }
    public string Socket { get;  }
}
