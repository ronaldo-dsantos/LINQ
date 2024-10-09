namespace Linq; // Dentro do Linq existem outros diversos métodos além dos abordados, como para fazer média, verificar duplicidade e etc...
public class TrabalhandoComLinq 
{
  public void AulaWhere() // Where é uma forma de aplicar filtros em uma fonte de dados
  {
    // Sintaxe de método

    /* // Uma maneira de usar a sintaxe de método
    var nomeCompleto = "RONALDO DOMINGUES";
    var resultado = nomeCompleto.Where(letra => letra == 'O'); // Forma direta de fazer o filtro
    
    foreach (var letra in resultado)
    {
      Console.WriteLine(letra);
    }
    */

    /* // Outra maneira de usar a sintaxe de método
    var nomeCompleto = "RONALDO DOMINGUES";
    Func<char, bool> filtro = letra => letra == 'O'; // Fazendo o filtro por uma Func, a vantagem de fazer dessa forma é que essa Func pode ser usada em outros lugares sem a necessidade de fazer um novo filtro
    var resultado = nomeCompleto.Where(filtro);

    foreach (var letra in resultado)
    {
      Console.WriteLine(letra);
    }
    */

    // Sintaxe de consulta
    /* // Uma maneira de usar a sintaxe de consulta
    var resultado = from c in nomeCompleto where c == 'O' select c; // c = caracter

    foreach (var letra in resultado)
    {
      Console.WriteLine(letra);
    }
    */

    var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

    var resultado = numeros.Where(numero => numero >= 10); // Fazendo o filtro em um array de números

    foreach (var numero in resultado)
    {
      Console.WriteLine(numero);
    }
  }

  public void AulaOrderBy() // Order By é uma forma de aplicar ordenação crescente ou decrescente em uma fonte de dados
  {
    var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

    // Ordenando em ordem crescente
    var ordenacaoCrescente = numeros.OrderBy(numero => numero);

    foreach (var numero in ordenacaoCrescente)
    {
      Console.WriteLine(numero);
    }

    // Ordenando em ordem decrescente
    var ordenacaoDecrescente = numeros.OrderByDescending(numero => numero);

    foreach (var numero in ordenacaoDecrescente)
    {
      Console.WriteLine(numero);
    }

    // Ordenando um array de strings
    var nomes = new string[] { "Ronaldo", "Rafael", "Eduardo" };

    var ordenacaoAlfabetica = nomes.OrderBy(nome => nome); // Ordenando por ordem alfabética, podemos usar OrderByDescending para ordenar ao contrário também

    foreach (var nome in ordenacaoAlfabetica)
    {
      Console.WriteLine(nome);
    }
  }

  public void AulaTake() // Take é uma forma de selecionar uma parte específica de uma fonte de dados
  {
    var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

    // Selecionando os 3 primeiros itens da coleção
    var resultado01 = numeros.Take(3);
    foreach (var numero in resultado01)
    {
      Console.WriteLine(numero);
    }

    // 3 primeiros que são maior que 10
    var resultado02 = numeros.Where(p => p >= 10).Take(3);
    foreach (var numero in resultado02)
    {
      Console.WriteLine(numero);
    }

    // 3 primeiros que são maior que 10 ordenado por ordem crescente
    var resultado03 = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);
    foreach (var numero in resultado03)
    {
      Console.WriteLine(numero);
    }
  }

  public void AulaCount() // Count é uma forma de contar a quantidade de itens de uma fonte de dados, onde podemos aplicar filtros também 
  {
    var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

    // Contando a quantidade de elementos da coleção
    var resultado01 = numeros.Count();
    Console.WriteLine(resultado01);

    // Contando a quantidade de elementos da coleção que seja maior que 10
    var resultado02 = numeros.Count(p => p > 10);
    Console.WriteLine(resultado02);
  }

  public void AulaFirstEFirstOrDefault() // First é uma forma de pegar o primeiro item de uma coleção ou o primeiro item a partir de um filtro
  {
    var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

    // Pegando o primeiro item da coleção, se a coleção for vazia retornará uma exception 
    var resultado01 = numeros.First();
    Console.WriteLine(resultado01);

    // Pegando o primeiro item da coleção que seja maior que 15, se não houver também retornará uma exception
    var resultado02 = numeros.First(p => p > 15);
    Console.WriteLine(resultado02);

    // Pegando o primeiro item da coleção, se a coleção for vazia retornará o valor padrão do tipo da coleção, no caso de int o retorno será 0 
    var resultado03 = numeros.FirstOrDefault();
    Console.WriteLine(resultado03);

    // Pegando o primeiro item da coleção que seja maior que 15, se não houver também retornará o valor padrão do tipo da coleção, no caso de int o retorno será 0
    var resultado04 = numeros.FirstOrDefault(p => p > 15);
    Console.WriteLine(resultado04);

    // Pegando o primeiro item da coleção que seja maior que 100, neste exemplo realizamos uma sobrecarga de método para que se o valor não existir, retornar por padrão -99
    var resultado05 = numeros.FirstOrDefault(p => p > 100, -99);
    Console.WriteLine(resultado05);
  }
}