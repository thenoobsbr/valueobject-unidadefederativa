using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public static class UnidadesFederativas
{
    private const int QUANTIDADE_ESTADOS = 29;

    private static readonly IDictionary<string, UnidadeFederativa> _unidadesFederativas =
        new Dictionary<string, UnidadeFederativa>(QUANTIDADE_ESTADOS, StringComparer.OrdinalIgnoreCase)
        {
            {Siglas.ACRE, new Acre()},
            {Siglas.ALAGOAS, new Alagoas()},
            {Siglas.AMAPA, new Amapa()},
            {Siglas.AMAZONAS, new Amazonas()},
            {Siglas.BAHIA, new Bahia()},
            {Siglas.CEARA, new Ceara()},
            {Siglas.DISTRITO_FEDERAL, new DistritoFederal()},
            {Siglas.ESPIRITO_SANTO, new EspiritoSanto()},
            {Siglas.GOIAS, new Goias()},
            {Siglas.MARANHAO, new Maranhao()},
            {Siglas.MATO_GROSSO, new MatoGrosso()},
            {Siglas.MATO_GROSSO_DO_SUL, new MatoGrossoDoSul()},
            {Siglas.MINAS_GERAIS, new MinasGerais()},
            {Siglas.PARA, new Para()},
            {Siglas.PARAIBA, new Paraiba()},
            {Siglas.PARANA, new Parana()},
            {Siglas.PERNAMBUCO, new Pernambuco()},
            {Siglas.PIAUI, new Piaui()},
            {Siglas.RIO_DE_JANEIRO, new RioDeJaneiro()},
            {Siglas.RIO_GRANDE_DO_NORTE, new RioGrandeDoNorte()},
            {Siglas.RIO_GRANDE_DO_SUL, new RioGrandeDoSul()},
            {Siglas.RONDONIA, new Rondonia()},
            {Siglas.RORAIMA, new Roraima()},
            {Siglas.SANTA_CATARINA, new SantaCatarina()},
            {Siglas.SAO_PAULO, new SaoPaulo()},
            {Siglas.SERGIPE, new Sergipe()},
            {Siglas.TOCANTINS, new Tocantins()},
            {Siglas.EXPORTACAO, new Exportacao()},
            {Siglas.EXTERIOR, new Exterior()}
        };

    public static UnidadeFederativa Acre => Get(Siglas.ACRE);
    public static UnidadeFederativa Alagoas => Get(Siglas.ALAGOAS);
    public static UnidadeFederativa Amapa => Get(Siglas.AMAPA);
    public static UnidadeFederativa Amazonas => Get(Siglas.AMAZONAS);
    public static UnidadeFederativa Bahia => Get(Siglas.BAHIA);
    public static UnidadeFederativa Ceara => Get(Siglas.CEARA);
    public static UnidadeFederativa DistritoFederal => Get(Siglas.DISTRITO_FEDERAL);
    public static UnidadeFederativa EspiritoSanto => Get(Siglas.ESPIRITO_SANTO);

    /// <summary>
    /// Utilizado em notas fiscais quando se trata de exportação.
    /// </summary>
    public static UnidadeFederativa Exportacao => Get(Siglas.EXPORTACAO);

    /// <summary>
    /// Utilizado em notas fiscais quando se trata de importação.
    /// </summary>
    public static UnidadeFederativa Exterior => Get(Siglas.EXTERIOR);

    public static UnidadeFederativa Goias => Get(Siglas.GOIAS);
    public static UnidadeFederativa Maranhao => Get(Siglas.MARANHAO);
    public static UnidadeFederativa MatoGrosso => Get(Siglas.MATO_GROSSO);
    public static UnidadeFederativa MatoGrossoDoSul => Get(Siglas.MATO_GROSSO_DO_SUL);
    public static UnidadeFederativa MinasGerais => Get(Siglas.MINAS_GERAIS);
    public static UnidadeFederativa Para => Get(Siglas.PARA);
    public static UnidadeFederativa Paraiba => Get(Siglas.PARAIBA);
    public static UnidadeFederativa Parana => Get(Siglas.PARANA);
    public static UnidadeFederativa Pernambuco => Get(Siglas.PERNAMBUCO);
    public static UnidadeFederativa Piaui => Get(Siglas.PIAUI);
    public static UnidadeFederativa RioDeJaneiro => Get(Siglas.RIO_DE_JANEIRO);
    public static UnidadeFederativa RioGrandeDoNorte => Get(Siglas.RIO_GRANDE_DO_NORTE);
    public static UnidadeFederativa RioGrandeDoSul => Get(Siglas.RIO_GRANDE_DO_SUL);
    public static UnidadeFederativa Rondonia => Get(Siglas.RONDONIA);
    public static UnidadeFederativa Roraima => Get(Siglas.RORAIMA);
    public static UnidadeFederativa SantaCatarina => Get(Siglas.SANTA_CATARINA);
    public static UnidadeFederativa SaoPaulo => Get(Siglas.SAO_PAULO);
    public static UnidadeFederativa Sergipe => Get(Siglas.SERGIPE);
    public static UnidadeFederativa Tocantins => Get(Siglas.TOCANTINS);

    public static UnidadeFederativa Get(string sigla)
    {
        if (_unidadesFederativas.TryGetValue(sigla, out var unidadeFederativa))
        {
            return unidadeFederativa;
        }

        throw new ArgumentException($"UF inválida: {sigla}", nameof(sigla));
    }
}
