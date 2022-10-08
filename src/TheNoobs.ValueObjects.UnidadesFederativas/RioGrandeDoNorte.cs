using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record RioGrandeDoNorte() : UnidadeFederativa(Siglas.RIO_GRANDE_DO_NORTE, "Rio Grande do Norte", new Nordeste());
