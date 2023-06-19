using ArqExercicios.Controllers;
using ArqExercicios.Data;
using ArqExercicios.Models;

namespace ArqExercicios.Views
{
    public class AnimalView
    {
        private AnimalController animalController;
        private Animal animal;
        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM CLIENTES");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animais");
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
                default:        
                break;
            }
        }

        private void List()
        {
            List<Animal> listagem = animalController.List();

            for(int i = 0; i< listagem.Count;i++)
            {
                Console.WriteLine( Print( listagem[i]));
            }

        }

        private string Print(Animal animal)
        {
            string retorno = "";
            retorno +="---------------------------------------\n";
            retorno += $"Id: {animal.Id} \n";
            retorno += $"Espécie: {animal.Species} \n";
            retorno += $"Nome: {animal.Name} \n";
            retorno += $"Raça: {animal.Race} \n";
            retorno += $"É um animal de estimação? {animal.Pet} \n";
            retorno +="---------------------------------------\n";

            return retorno;


        }
        private void Insert()
        {
            Animal animal = new Animal();
            animal.Id = animalController.GetNextId();

            Console.WriteLine("Informe a espécie do animal:");
            animal.Species = Console.ReadLine();

            Console.WriteLine("Informe o nome:");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Informe a raça do animal:");
            animal.Race = Console.ReadLine();

            Console.WriteLine("É um animal de Estimação?");
            animal.Pet = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if(retorno)
                Console.WriteLine("Animal inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }
    }
}