using ClinicaVeterinaria.Views;

namespace ClinicaVeterinaria.View
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            do
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("Programa para leitura e exportação de dados");
                Console.WriteLine("*******************************************");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastros");
                Console.WriteLine("2 - Relatórios");
                Console.WriteLine("0 - SAIR");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        int subOption1 = 0;
                        do
                        {
                            Console.WriteLine("1.1 - Médicos");
                            Console.WriteLine("1.2 - Animais");
                            Console.WriteLine("1.3 - Atendimentos");
                            Console.WriteLine("1.4 - SAIR");

                            subOption1 = Convert.ToInt32(Console.ReadLine());

                            switch (subOption1)
                            {
                                case 1:
                                    Console.WriteLine("Cadastro de médicos");
                                    MedicoView medicoView = new MedicoView();
                                    break;

                                case 2:
                                    Console.WriteLine("Cadastro de animais");
                                    AnimalView animalView = new AnimalView();
                                    break;

                                case 3:
                                    Console.WriteLine("Cadastro de atendimentos");
                                    // Implemente o código para cadastrar atendimentos aqui
                                    break;

                                case 4:
                                    Console.WriteLine("Voltando para o menu principal");
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                        } while (subOption1 != 4);
                        break;

                    case 2:
                        int subOption2 = 0;
                        do
                        {
                            Console.WriteLine("2.1 - Relatório de animais");
                            Console.WriteLine("2.2 - Relatório de atendimentos");
                            Console.WriteLine("2.3 - SAIR");

                            subOption2 = Convert.ToInt32(Console.ReadLine());

                            switch (subOption2)
                            {
                                case 1:
                                    Console.WriteLine("Gerando relatório de animais");
                                    // Implemente o código para gerar o relatório de animais aqui
                                    break;

                                case 2:
                                    Console.WriteLine("Gerando relatório de atendimentos");
                                    // Implemente o código para gerar o relatório de atendimentos aqui
                                    break;

                                case 3:
                                    Console.WriteLine("Voltando para o menu principal");
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                        } while (subOption2 != 3);
                        break;

                    case 0:
                        Console.WriteLine("Saindo do programa");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (option != 0);
        }
    }
}
