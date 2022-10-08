using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record MatoGrossoDoSul() : UnidadeFederativa(Siglas.MATO_GROSSO_DO_SUL, "Mato Grosso do Sul", new CentroOeste());
