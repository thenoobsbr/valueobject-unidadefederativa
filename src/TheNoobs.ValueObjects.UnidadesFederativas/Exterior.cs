using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes.Abstractions;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record Exterior() : UnidadeFederativa(Siglas.EXTERIOR, "Exterior", Regiao.Nenhuma);
