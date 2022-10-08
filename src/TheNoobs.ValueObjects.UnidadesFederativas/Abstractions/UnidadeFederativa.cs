using TheNoobs.ValueObjects.UnidadesFederativas.Regioes.Abstractions;

namespace TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;

public abstract record UnidadeFederativa
{
    private protected UnidadeFederativa(string sigla, string nome, Regiao regiao)
    {
        Nome = nome;
        Regiao = regiao;
        Sigla = sigla;
    }

    public string Nome { get; }
    public Regiao Regiao { get; }
    public string Sigla { get; }
}
