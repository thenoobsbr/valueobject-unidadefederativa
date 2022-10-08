using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes.Abstractions;

namespace TheNoobs.ValueObjects.UnidadesFederativas.UnitTests.TestData;

public static class UnidadesFederativasTestData
{
    public static IEnumerable<object[]> ObterUnidadesFederativasParaValidacao()
    {
        yield return new object[] { new Acre(), UnidadesFederativas.Acre, "AC", "Acre", new Norte() };
        yield return new object[] { new Alagoas(), UnidadesFederativas.Alagoas, "AL", "Alagoas", new Nordeste() };
        yield return new object[] { new Amapa(), UnidadesFederativas.Amapa, "AP", "Amapá", new Norte() };
        yield return new object[] { new Amazonas(), UnidadesFederativas.Amazonas, "AM", "Amazonas", new Norte() };
        yield return new object[] { new Bahia(), UnidadesFederativas.Bahia, "BA", "Bahia", new Nordeste() };
        yield return new object[] { new Ceara(), UnidadesFederativas.Ceara, "CE", "Ceará", new Nordeste() };
        yield return new object[] { new EspiritoSanto(), UnidadesFederativas.EspiritoSanto, "ES", "Espírito Santo", new Sudeste() };
        yield return new object[] { new Goias(), UnidadesFederativas.Goias, "GO", "Goiás", new CentroOeste() };
        yield return new object[] { new Maranhao(), UnidadesFederativas.Maranhao, "MA", "Maranhão", new Nordeste() };
        yield return new object[] { new MatoGrosso(), UnidadesFederativas.MatoGrosso, "MT", "Mato Grosso", new CentroOeste() };
        yield return new object[] { new MatoGrossoDoSul(), UnidadesFederativas.MatoGrossoDoSul, "MS", "Mato Grosso do Sul", new CentroOeste() };
        yield return new object[] { new MinasGerais(), UnidadesFederativas.MinasGerais, "MG", "Minas Gerais", new Sudeste() };
        yield return new object[] { new Para(), UnidadesFederativas.Para, "PA", "Pará", new Norte() };
        yield return new object[] { new Paraiba(), UnidadesFederativas.Paraiba, "PB", "Paraíba", new Nordeste() };
        yield return new object[] { new Parana(), UnidadesFederativas.Parana, "PR", "Paraná", new Sul() };
        yield return new object[] { new Pernambuco(), UnidadesFederativas.Pernambuco, "PE", "Pernambuco", new Nordeste() };
        yield return new object[] { new Piaui(), UnidadesFederativas.Piaui, "PI", "Piauí", new Nordeste() };
        yield return new object[] { new RioDeJaneiro(), UnidadesFederativas.RioDeJaneiro, "RJ", "Rio de Janeiro", new Sudeste() };
        yield return new object[] { new RioGrandeDoNorte(), UnidadesFederativas.RioGrandeDoNorte, "RN", "Rio Grande do Norte", new Nordeste() };
        yield return new object[] { new RioGrandeDoSul(), UnidadesFederativas.RioGrandeDoSul, "RS", "Rio Grande do Sul", new Sul() };
        yield return new object[] { new Rondonia(), UnidadesFederativas.Rondonia, "RO", "Rondônia", new Norte() };
        yield return new object[] { new Roraima(), UnidadesFederativas.Roraima, "RR", "Roraima", new Norte() };
        yield return new object[] { new SantaCatarina(), UnidadesFederativas.SantaCatarina, "SC", "Santa Catarina", new Sul() };
        yield return new object[] { new SaoPaulo(), UnidadesFederativas.SaoPaulo, "SP", "São Paulo", new Sudeste() };
        yield return new object[] { new Sergipe(), UnidadesFederativas.Sergipe, "SE", "Sergipe", new Nordeste() };
        yield return new object[] { new Tocantins(), UnidadesFederativas.Tocantins, "TO", "Tocantins", new Norte() };
        yield return new object[] { new DistritoFederal(), UnidadesFederativas.DistritoFederal, "DF", "Distrito Federal", new CentroOeste() };
        yield return new object[] { new Exportacao(), UnidadesFederativas.Exportacao, "XX", "Exportação", Regiao.Nenhuma };
        yield return new object[] { new Exterior(), UnidadesFederativas.Exterior, "EX", "Exterior", Regiao.Nenhuma };
    }

    public static IEnumerable<object[]> SiglasInvalidasParaRecuperacaoDeUnidadesFederativas()
    {
        yield return new object[] { "AK" };
        yield return new object[] { "CO" };
        yield return new object[] { "DE" };
    }

    public static IEnumerable<object[]> SiglasValidasParaRecuperacaoDeUnidadesFederativas()
    {
        yield return new object[] { "AC", new Acre() };
        yield return new object[] { "AL", new Alagoas() };
        yield return new object[] { "AP", new Amapa() };
        yield return new object[] { "AM", new Amazonas() };
        yield return new object[] { "BA", new Bahia() };
        yield return new object[] { "CE", new Ceara() };
        yield return new object[] { "ES", new EspiritoSanto() };
        yield return new object[] { "GO", new Goias() };
        yield return new object[] { "MA", new Maranhao() };
        yield return new object[] { "MT", new MatoGrosso() };
        yield return new object[] { "MS", new MatoGrossoDoSul() };
        yield return new object[] { "MG", new MinasGerais() };
        yield return new object[] { "PA", new Para() };
        yield return new object[] { "PB", new Paraiba() };
        yield return new object[] { "PR", new Parana() };
        yield return new object[] { "PE", new Pernambuco() };
        yield return new object[] { "PI", new Piaui() };
        yield return new object[] { "Rj", new RioDeJaneiro() };
        yield return new object[] { "RN", new RioGrandeDoNorte() };
        yield return new object[] { "RS", new RioGrandeDoSul() };
        yield return new object[] { "RO", new Rondonia() };
        yield return new object[] { "RR", new Roraima() };
        yield return new object[] { "SC", new SantaCatarina() };
        yield return new object[] { "SP", new SaoPaulo() };
        yield return new object[] { "sE", new Sergipe() };
        yield return new object[] { "to", new Tocantins() };
        yield return new object[] { "DF", new DistritoFederal() };
        yield return new object[] { "XX", new Exportacao() };
        yield return new object[] { "EX", new Exterior() };
    }

    public static IEnumerable<object[]> UnidadesFederativasParaComparacao()
    {
        yield return new object[] { UnidadesFederativas.Acre, UnidadesFederativas.Tocantins, false };
        yield return new object[] { UnidadesFederativas.RioDeJaneiro, UnidadesFederativas.SaoPaulo, false };
        yield return new object[] { UnidadesFederativas.Bahia, UnidadesFederativas.Bahia, true };
        yield return new object[] { UnidadesFederativas.SantaCatarina, UnidadesFederativas.RioDeJaneiro, false };
    }
}
