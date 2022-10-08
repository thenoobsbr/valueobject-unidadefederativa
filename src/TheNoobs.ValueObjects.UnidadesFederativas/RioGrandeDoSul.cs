using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record RioGrandeDoSul() : UnidadeFederativa(Siglas.RIO_GRANDE_DO_SUL, "Rio Grande do Sul", new Sul());
