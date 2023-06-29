using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Views
{
    public class ClinicaView
    {
        private ClinicaController clinicaController;
        public ClinicaView()
        {
            clinicaController = new ClinicaController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM CLÍNICAS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clinica");
            Console.WriteLine("2 - Listar Clinicas");
            Console.WriteLine("3 - Exportar Clinicas");
            Console.WriteLine("4 - Importar Clinicas");
            Console.WriteLine("5 - Pesquisar Clinicas");
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
                case 5:
                    SearchByName();
                break;
                
                default:        
                break;
            }
        }

        private void List()
        {
            List<Clinica> listagem = clinicaController.List();

            for(int i = 0; i< listagem.Count;i++)
            {
                Console.WriteLine( Print( listagem[i]));
            }

        }

        private string Print(Clinica clinica)
        {
            string retorno = "";
            retorno +="---------------------------------------\n";
            retorno += $"Id: {clinica.Id} \n";
            retorno += $"Nome:{clinica.Name}  \n";
            retorno += $"Telefone:{clinica.Telefone}  \n";
            retorno += $"Endereço:{clinica.Endereco} \n";
            retorno += $"Bairro: {clinica.Bairro} \n";
            retorno += $"Número: {clinica.Numero} \n";
            retorno +="---------------------------------------\n";

            return retorno;


        }
        private void Insert()
        {
            Clinica clinica = new Clinica();
            clinica.Id = clinicaController.GetNextId();

            Console.WriteLine("Informe o nome:");
            clinica.Name = Console.ReadLine();

            Console.WriteLine("Informe o telefone:");
            clinica.Telefone = Console.ReadLine();

            Console.WriteLine("Informe o Endereço:");
            clinica.Endereco = Console.ReadLine();

            Console.WriteLine("Infome o Bairro");
            clinica.Bairro = Console.ReadLine();

            bool retorno = clinicaController.Insert(clinica);

            if(retorno)
                Console.WriteLine("Cliente inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }

        private void Export()
        {
            if(clinicaController.ExportToTextFile() )
                Console.WriteLine("Arquivo gerado com sucesso!");         
            else
                Console.Write("Oooooops.");
            
        }

        private void Import()
        {
           if(clinicaController.ImportFromTxtFile() )
                Console.WriteLine("Arquivo importado com sucesso!");
            else
                Console.WriteLine("Oooooops."); 
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar Clinica pelo Nome.");
            Console.WriteLine("Digite o nome da Clinica:");
            string name = Console.ReadLine();

            foreach(Clinica c in 
                clinicaController.SearchByName(name))
            {
                Console.WriteLine(c.ToString() );
            }
        }

        
    }
}