# valueobject-unidadefederativa

ValueObjects que representam as Unidades Federativas (UFs) do Brasil.

[![Nuget](https://buildstats.info/nuget/TheNoobs.ValueObjects.UnidadesFederativas)](https://www.nuget.org/packages/TheNoobs.ValueObjects.UnidadesFederativas)
![License](https://img.shields.io/github/license/thenoobsbr/valueobjects-unidadesfederativas)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=thenoobsbr_valueobjects-unidadefederativa&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=thenoobsbr_valueobjects-unidadefederativa)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=thenoobsbr_valueobjects-unidadefederativa&metric=bugs)](https://sonarcloud.io/summary/new_code?id=thenoobsbr_valueobjects-unidadefederativa)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=thenoobsbr_valueobjects-unidadefederativa&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=thenoobsbr_valueobjects-unidadefederativa)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=thenoobsbr_valueobjects-unidadefederativa&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=thenoobsbr_valueobjects-unidadefederativa)

## Como usar

Você pode instanciar cada estado através de seu construtor específico:

```csharp
var uf = new Acre();
```

Ou através do `ObjectPool` de unidades federativas:

```csharp
var uf = UnidadesFederativas.RioDeJaneiro;
```

E ainda, pode-se obter uma `UnidadeFederativa` através de sua siglas, seja usando uma string:

```csharp
var uf = UnidadesFederativas.Get("GO");
```

---
> ♥ Made with love!
Ou através das constantes:

```csharp
var uf = UnidadesFederativas.Get(Siglas.SAO_PAULO);
```

Caso seja passada uma sigla inválida para o método Get, uma exceção do tipo `ArgumentException` será disparada.
