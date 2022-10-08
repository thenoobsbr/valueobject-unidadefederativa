using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record SantaCatarina() : UnidadeFederativa(Siglas.SANTA_CATARINA, "Santa Catarina", new Sul());
