using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record EspiritoSanto() : UnidadeFederativa(Siglas.ESPIRITO_SANTO, "Espírito Santo", new Sudeste());
