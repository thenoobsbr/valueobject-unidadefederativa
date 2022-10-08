# valueobject-unidadefederativa

ValueObjects que representam as Unidades Federativas (UFs) do Brasil.

## Como usar

Voc� pode instanciar cada estado atrav�s de seu construtor espec�fico:

```csharp
var uf = new Acre();
```

Ou atrav�s do `ObjectPool` de unidades federativas:

```csharp
var uf = UnidadesFederativas.RioDeJaneiro;
```

E ainda, pode-se obter uma `UnidadeFederativa` atrav�s de sua siglas, seja usando uma string:

```csharp
var uf = UnidadesFederativas.Get("GO");
```

Ou atrav�s das constantes:

```csharp
var uf = UnidadesFederativas.Get(Siglas.SAO_PAULO);
```

Caso seja passada uma sigla inv�lida para o m�todo Get, uma exce��o do tipo `ArgumentException` ser� disparada.