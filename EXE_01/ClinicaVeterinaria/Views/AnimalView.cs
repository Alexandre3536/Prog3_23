


using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Views
{
    public class AnimalView
    {
        private AnimalController animalController;
        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM ANIMAIS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animal");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Exportar Animais");
            Console.WriteLine("4 - Importar Animais");
            Console.WriteLine("");
            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1 :
                    Insert();
                break;
                case 2 :
                    List();
                break;
                
                case 3 :
                    Export();
                break;
                case 4 :
                    Import();
                break;
                
                default:        
                break;
            }
        }

        private void List()
        {
            List<Animall> listagem = animalController.List();

            for(int i = 0; i< listagem.Count;i++)
            {
                Console.WriteLine( Print( listagem[i]));
            }

        }

        private string Print(Animall animall)
        {
            string retorno = "";
            retorno +="---------------------------------------\n";
            retorno += $"Id: {animall.Id} \n";
            retorno += $"Espécie:{animall.Species}  \n";
            retorno += $"Nome:{animall.Name}  \n";
            retorno += $"Raça:{animall.Race} \n";
            retorno += $"É animal de estimação? {animall.Pet} \n";
            retorno +="---------------------------------------\n";

            return retorno;


        }
        private void Insert()
        {
            Animall animall = new Animall();
            animall.Id = animalController.GetNextId();

            Console.WriteLine("Informe a espécie:");
            animall.Species = Console.ReadLine();

            Console.WriteLine("Informe o nome:");
            animall.Name = Console.ReadLine();

            Console.WriteLine("Informe a raça:");
            animall.Race = Console.ReadLine();

            Console.WriteLine("É animal de estimação?");
            animall.Pet = Console.ReadLine();

            bool retorno = animalController.Insert(animall);

            if(retorno)
                Console.WriteLine("Cliente inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }

        private void Export()
        {
            if(animalController.ExportToTextFile() )
                Console.WriteLine("Arquivo gerado com sucesso!");         
            else
                Console.Write("Oooooops.");
            
        }

        private void Import()
        {
           if(animalController.ImportFromTxtFile() )
                Console.WriteLine("Arquivo importado com sucesso!");
            else
                Console.WriteLine("Oooooops."); 
        }
    }
}