using System;

namespace Dados_Cadastrais_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados_Pessoais dados_pessoais = new Dados_Pessoais();

            Console.Write("Gostaria de se cadastrar? digite 's' para sim ou 'n' para não - ");
            string opcao = Console.ReadLine();
            Console.WriteLine();
            int i = 0;

            while (opcao != "s" & opcao != "n")
            {
                Console.Write("Digite 's' para sim ou 'n' para não - ");
                opcao = Console.ReadLine();
            }
            Console.WriteLine();

            if (opcao == "n")
            {
                Console.WriteLine("Obrigado pela visita!!! ");
            }
            else
            {
                while (opcao == "s")
                {

                    while (opcao == "s")
                    {
                        Console.WriteLine();
                        Console.Write("Digite o nome: ");
                        dados_pessoais.Nome[i] = Console.ReadLine();

                        Console.Write("Digite a idade: ");
                        dados_pessoais.Idade[i] = int.Parse(Console.ReadLine());

                        Console.Write("Digite o CPF: ");
                        dados_pessoais.Cpf[i] = Console.ReadLine();
                        Console.WriteLine();

                        i++;

                        Console.Write("Gostaria de cadastrar outra Pessoa? digite 's' para sim ou 'n' para não - ");
                        opcao = Console.ReadLine();
                        Console.WriteLine();
                    }

                    Console.WriteLine("Confira seus dados: ");

                    int j = 0;
                    for (j = 0; j < i; j++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nome.... " + dados_pessoais.Nome[j]);
                        Console.WriteLine("Idade... " + dados_pessoais.Idade[j] + " anos");
                        Console.WriteLine("CPF..... " + dados_pessoais.Cpf[j]);

                    }
                    Console.WriteLine();
                    Console.Write ("Estão corretos? digite: 1 para sim ou 2 para não? - ");

                    int escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Cadastro efetuado com sucesso!!!");
                    }
                    else
                    {
                        Console.Write("Corrigir os erros - digite 's' para sim ou 'n' para não - ");
                        opcao = Console.ReadLine();
                        Console.WriteLine();
                        i = 0;
                    }
                }

            }

        }
    }
}
