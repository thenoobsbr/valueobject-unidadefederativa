using FluentAssertions;
using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.UnitTests.TestData;
using Xunit;

namespace TheNoobs.ValueObjects.UnidadesFederativas.UnitTests;

[Trait("Category", "UnitTests")]
[Trait("Class", nameof(UnidadeFederativa))]
public class UnidadesFederativasTests
{
    [Theory]
    [MemberData(nameof(UnidadesFederativasTestData.UnidadesFederativasParaComparacao),
        MemberType = typeof(UnidadesFederativasTestData))]
    public void Given_DoisUFs_When_ForemComparados_Then_OResultadoDaComparacaoDeveSerOEsperado(
        UnidadeFederativa uf1,
        UnidadeFederativa uf2,
        bool resultadoEsperado)
    {
        uf1.Equals(uf2).Should().Be(resultadoEsperado);
        (uf1 == uf2).Should().Be(resultadoEsperado);
        (uf1 != uf2).Should().NotBe(resultadoEsperado);
    }

    [Theory]
    [MemberData(nameof(UnidadesFederativasTestData.SiglasInvalidasParaRecuperacaoDeUnidadesFederativas),
        MemberType = typeof(UnidadesFederativasTestData))]
    public void Given_UmaSiglaInvalida_When_SeTentarRecuperarAUF_Then_DeveSerDisparadaUmaExcecao(string sigla)
    {
        UnidadeFederativa? uf = null;
        Action act = () => uf = UnidadesFederativas.Get(sigla);

        act.Should()
            .ThrowExactly<ArgumentException>()
            .WithMessage($"UF inválida: {sigla} (Parameter '{nameof(sigla)}')");

        uf.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(UnidadesFederativasTestData.SiglasValidasParaRecuperacaoDeUnidadesFederativas),
        MemberType = typeof(UnidadesFederativasTestData))]
    public void Given_UmaSiglaValida_When_SeTentarRecuperarAUF_Then_DeveSerRecuperadaCorretamente(
        string sigla,
        UnidadeFederativa ufEsperada)
    {
        UnidadesFederativas.Get(sigla).Should().Be(ufEsperada);
    }

    [Theory]
    [MemberData(nameof(UnidadesFederativasTestData.ObterUnidadesFederativasParaValidacao),
        MemberType = typeof(UnidadesFederativasTestData))]
    public void Given_UmaUnidadeFederativa_When_SeValidaOsDados_Then_EstesDevemEstarCorretos(UnidadeFederativa uf1, UnidadeFederativa uf2, string siglaEsperada, string nomeEsperado, Regiao regiaoEsperada)
    {
        uf1.Sigla.Should().Be(siglaEsperada);
        uf1.Nome.Should().Be(nomeEsperado);
        uf1.Regiao.Should().Be(regiaoEsperada);
        uf2.Sigla.Should().Be(siglaEsperada);
        uf2.Nome.Should().Be(nomeEsperado);
        uf2.Regiao.Should().Be(regiaoEsperada);
        uf1.Should().Be(uf2);
        uf1.ToString().Should().Be(uf2.ToString());
    }
}
