using System.IO;
using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Controllers
{

   
    public class MedicoController
    {
        private string directoryName = "ReportFiles";
        private string fileName  = "Medico.txt";
        public List<Medico> List()
        {
            return DataSet.Medicos;
        }
         public bool Insert(Medico medico)
         {
            if( medico == null)
                return false;

            if(medico.Id<=0)
                return false;

            if( string.IsNullOrWhiteSpace(medico.FirstName))
                return false;

            DataSet.Medicos.Add(medico);

            return true;
         }

         public bool ExportToTextFile()
         {
            
            if(!Directory.Exists(directoryName))
             Directory.CreateDirectory(directoryName);
            
            string fileContent = string.Empty;
            foreach(Medico c in DataSet.Medicos)
            {
                fileContent += $"{c.Id};{c.CPF};{c.FirstName};{c.LastName}; {c.Email}";
                fileContent += "\n";
            }
            try
            {
                StreamWriter sw = File.CreateText($"{directoryName}\\{fileName}");
                sw.Write(fileContent);
                sw.Close();
            }
            catch(IOException ioEx)
            {
                Console.WriteLine("Erro ao manipular o arquivo.");
                Console.WriteLine(ioEx.Message);
                return false;
            }

            return true;
               
         }

        public bool ImportFromTxtFile()
        {
            try
            {
            StreamReader sr = new StreamReader($"{directoryName}\\{fileName}");
            string line = string.Empty;
            line = sr.ReadLine();
            while(line != null)
            {
                Medico medico = new Medico();
                string[] medicoData = line.Split(';');
                medico.Id = Convert.ToInt32(medicoData[0] ) ;
                medico.CPF = medicoData[1];
                medico.FirstName = medicoData[2];
                medico.LastName = medicoData[3];
                medico.Email = medicoData[4];

                DataSet.Medicos.Add(medico);

                line = sr.ReadLine();
            }
            return true;
        }
            catch(Exception ex)
            {
                Console.WriteLine("Oooops! Ocorreu um erro ao tentar importar os dados.");
                Console.WriteLine(ex.Message);
                return false;
            }
          

        }
        public int GetNextId()
        {
            int tam = DataSet.Medicos.Count;
            if( tam > 0)
                return DataSet.Medicos[tam - 1].Id +1;
            else
                return 1;
    
            
        }
    }
}