using System;

class Program
{
    static void Main(string[] args)
    {
        bool sair = false;

        while (!sair)
        {
            ExibirMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExibirMenuCadastros();
                    string opcaoCadastros = Console.ReadLine();

                    switch (opcaoCadastros)
                    {
                        case "1.1":
                            Console.WriteLine("Opção 1.1 selecionada (Cadastro de Médicos)");
                            // Implemente o código para cadastro de médicos
                            break;
                        case "1.2":
                            Console.WriteLine("Opção 1.2 selecionada (Cadastro de Animais)");
                            // Implemente o código para cadastro de animais
                            break;
                        case "1.3":
                            Console.WriteLine("Opção 1.3 selecionada (Cadastro de Atendimentos)");
                            // Implemente o código para cadastro de atendimentos
                            break;
                        case "1.4":
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;

                case "2":
                    ExibirMenuRelatorios();
                    string opcaoRelatorios = Console.ReadLine();

                    switch (opcaoRelatorios)
                    {
                        case "2.1":
                            Console.WriteLine("Opção 2.1 selecionada (Relatório de Animais)");
                            // Implemente o código para gerar relatório de animais
                            break;
                        case "2.2":
                            Console.WriteLine("Opção 2.2 selecionada (Relatório de Atendimentos)");
                            // Implemente o código para gerar relatório de atendimentos
                            break;
                        case "2.3":
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;

                case "0":
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("---- Menu Principal ----");
        Console.WriteLine("1 - Cadastros");
        Console.WriteLine("    1.1 - Médicos");
        Console.WriteLine("    1.2 - Animais");
        Console.WriteLine("    1.3 - Atendimentos");
        Console.WriteLine("    1.4 - SAIR");
        Console.WriteLine("2 - Relatórios");
        Console.WriteLine("    2.1 - Animais");
        Console.WriteLine("    2.2 - Atendimentos");
        Console.WriteLine("    2.3 - SAIR");
        Console.WriteLine("0 - SAIR");
        Console.Write("Escolha uma opção: ");
    }

    static void ExibirMenuCadastros()
    {
        Console.WriteLine("---- Menu Cadastros ----");
        Console.WriteLine("1.1 - Médicos");
        Console.WriteLine("1.2 - Animais");
        Console.WriteLine("1.3 - Atendimentos");
        Console.WriteLine("1.4 - SAIR");
        Console.Write("Escolha uma opção: ");
    }

    static void ExibirMenuRelatorios()
    {
        Console.WriteLine("---- Menu Relatórios ----");
        Console.WriteLine("2.1 - Animais");
        Console.WriteLine("2.2 - Atendimentos");
        Console.WriteLine("2.3 - SAIR");
        Console.Write("Escolha uma opção: ");
    }
}

