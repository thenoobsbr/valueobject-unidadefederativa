# valueobject-unidadefederativa

ValueObjects que representam as Unidades Federativas (UFs) do Brasil.

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

Ou através das constantes:

```csharp
var uf = UnidadesFederativas.Get(Siglas.SAO_PAULO);
```

Caso seja passada uma sigla inválida para o método Get, uma exceção do tipo `ArgumentException` será disparada.