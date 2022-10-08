namespace TheNoobs.ValueObjects.UnidadesFederativas.Regioes.Abstractions;

public abstract record Regiao
{
    private protected Regiao()
    {
    }

    public abstract string Nome { get; }

    public static Regiao Nenhuma => new RegiaoVazia();

    private sealed record RegiaoVazia : Regiao
    {
        public override string Nome => string.Empty;
    }
}
