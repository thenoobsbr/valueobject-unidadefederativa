using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record RioDeJaneiro() : UnidadeFederativa(Siglas.RIO_DE_JANEIRO, "Rio de Janeiro", new Sudeste());
