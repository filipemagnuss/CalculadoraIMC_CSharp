using System.ComponentModel.Design;

do
{
  int idade;
  double altura, peso, imc;
  string nome;
  string faixa_etaria;
  string opcao;

  Console.WriteLine("Digite seu nome:"); /* Momento em que pedimos os dados do usuario */
  nome = Console.ReadLine();

  Console.WriteLine("Digite sua altura:");
  altura = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("Digite seu peso:");
  peso = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("Digite sua idade:");
  idade = Convert.ToInt32(Console.ReadLine());

  imc = peso / (altura * altura);  /* Formula para fazer o calculo do imc */

  if (idade <= 9) /* Sequencia de comparações para declarar se a pessoa é uma criança, adolecente, adulta ou idosa */
  {
    faixa_etaria = "criança";
  }
  else
  {
    if (idade >= 11 && idade <= 19)
    {
      faixa_etaria = "Adolecente";
    }
    else
    {
      if (idade >= 20 && idade <= 59)
      {
        faixa_etaria = "Adulto";
      }
      else
      {
        faixa_etaria = "Idoso";

      }

    }
  }
  if (imc <= 18) /* Sequencia de comparações para se o usuario esta no peso ideal */
  {
    Console.WriteLine($"Você é considerado {faixa_etaria}, tem {idade} anos, pesa {peso} quilos, tem {altura} de altura, você é considerado magro seu imc é {imc:F2} ");
  }
  else
  {
    if (imc >= 19 && imc <= 24)
    {
      Console.WriteLine($"Você é considerado {faixa_etaria}, tem {idade} anos, pesa {peso} quilos, tem {altura} de altura, você é considerado normal seu imc é {imc:F2} ");
    }
    else
    {
      if (imc >= 25 && imc <= 29)
      {
        Console.WriteLine($"Você é considerado {faixa_etaria}, tem {idade} anos, pesa {peso} quilos, tem {altura} de altura, você esta com sobrepeso seu imc é {imc:F2} ");
      }
      else
      {
        Console.WriteLine("Você é considerado " + faixa_etaria + ", tem " + idade + " anos, pesa " + peso + " quilos, tem " + altura + " de altura, você é considerado obeso seu imc é " + imc );
      }
    }
  }

  Console.WriteLine("Você deseja fazer outro calculo? S/N"); /* Menu basico para fazer um novo calculo ou encerrar o app */
  opcao = Convert.ToString(Console.ReadLine());
  if (opcao.ToUpper() != "S")
  {
    break;
  }
} while (true);



