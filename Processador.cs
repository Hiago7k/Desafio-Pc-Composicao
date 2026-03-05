namespace Desafio_Pc_Composicao;

internal class Processador
{
    public Processador(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public string Marca { get;  }
    public string Modelo { get;  }
}
