using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes.Abstractions;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record Exportacao() : UnidadeFederativa(Siglas.EXPORTACAO, "Exportação", Regiao.Nenhuma);
