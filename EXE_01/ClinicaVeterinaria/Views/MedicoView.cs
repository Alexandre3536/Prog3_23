


using ClinicaVeterinaria.Controllers;
using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Views
{
    public class MedicoView
    {
        private MedicoController medicoController;
        public MedicoView()
        {
            medicoController = new MedicoController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM MÉDICOS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Médico");
            Console.WriteLine("2 - Listar Médicos");
            Console.WriteLine("3 - Exportar Médicos");
            Console.WriteLine("4 - Importar Médicos");
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
            List<Medico> listagem = medicoController.List();

            for(int i = 0; i< listagem.Count;i++)
            {
                Console.WriteLine( Print( listagem[i]));
            }

        }

        private string Print(Medico medico)
        {
            string retorno = "";
            retorno +="---------------------------------------\n";
            retorno += $"Id: {medico.Id} \n";
            retorno += $"Nome:{medico.FirstName} {medico.LastName} \n";
            retorno += $"E-mail:{medico.Email} \n";
            retorno += $"CPF: {medico.CPF} \n";
            retorno +="---------------------------------------\n";

            return retorno;


        }
        private void Insert()
        {
            Medico medico = new Medico();
            medico.Id = medicoController.GetNextId();

            Console.WriteLine("Informe o primeiro nome:");
            medico.FirstName = Console.ReadLine();

            Console.WriteLine("Informe o sobrenome:");
            medico.LastName = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            medico.CPF = Console.ReadLine();

            Console.WriteLine("Informe o email:");
            medico.Email = Console.ReadLine();

            bool retorno = medicoController.Insert(medico);

            if(retorno)
                Console.WriteLine("Cliente inserido com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }

        private void Export()
        {
            if(medicoController.ExportToTextFile() )
                Console.WriteLine("Arquivo gerado com sucesso!");         
            else
                Console.Write("Oooooops.");
            
        }

        private void Import()
        {
           if(medicoController.ImportFromTxtFile() )
                Console.WriteLine("Arquivo importado com sucesso!");
            else
                Console.WriteLine("Oooooops."); 
        }
    }
}