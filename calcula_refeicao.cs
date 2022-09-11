double gramas, valor, tara, valorRefeicao;
string sair = "";

do

try{

  Console.WriteLine("\n+----- Calculando o valor da refeição -----+\n");

  //Campos para inserir os dados para efetuar o cálculo

  Console.Write("Informe a tara do prato......:");
  tara = Convert.ToDouble(Console.ReadLine()!);

  Console.Write("Informe o valor do prato.....:");
  valor = Convert.ToDouble(Console.ReadLine()!);

  Console.Write("Informe o peso do prato......:");
  gramas = Convert.ToDouble(Console.ReadLine()!);
  gramas = gramas * 1.000;

  if(valor == 0 || gramas == 0 || tara == 0){
    throw new DivideByZeroException();

  }

  //Calcula o valor da refeição do cliente

  valorRefeicao = (gramas * valor) - tara;

  //Exibe o valor a ser pago pela refeição

  Console.WriteLine($"\nO prato de {gramas} gramas custa: R$ {valorRefeicao:N2}");

  //Fechamento do programa e tratamento das exceções

  Console.Write("\nDigite 0 para sair do programa:");
  sair = Console.ReadLine()!;
  
  if (sair != "0"){
    throw new Exception();

  }

}

catch(FormatException)
{

  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Fotmato inválido! Digite um número!");
  Console.ResetColor();
  Console.WriteLine("\nPressione uma tecla para retornar ao inicio.");
  Console.ReadKey();

} 
catch (DivideByZeroException)
{

  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Não foi possível calcular o valor da Refeição, digite um valor válido!");
  Console.ResetColor();
  Console.WriteLine("\nPressione uma tecla para retornar ao menu inicial");
  Console.ReadKey();

}
catch(Exception)
{

  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Valor inválido!");
  Console.WriteLine("\nPressione uma tecla para retornar ao menu inicial");
  Console.ReadKey();

}


while (sair != "0" );{

  Console.WriteLine("\nObrigado por utilizar nosso programa! :)") ;
  Environment.Exit(0);

}