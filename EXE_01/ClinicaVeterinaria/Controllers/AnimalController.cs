using System.IO;
using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Controllers
{

   
    public class AnimalController
    {
        private string directorySpecies = "ReportFiles";
        private string Species  = "Animal.txt";
        public List<Animall> List()
        {
            return DataSet.Animalls;
        }
         public bool Insert(Animall animall)
         {
            if( animall == null)
                return false;

            if(animall.Id<=0)
                return false;

            if( string.IsNullOrWhiteSpace(animall.Species))
                return false;

            DataSet.Animalls.Add(animall);

            return true;
         }

         public bool ExportToTextFile()
         {
            
            if(!Directory.Exists(directorySpecies))
             Directory.CreateDirectory(Species);
            
            string fileContent = string.Empty;
            foreach(Animall c in DataSet.Animalls)
            {
                fileContent += $"{c.Id};{c.Species};{c.Name};{c.Race}; {c.Pet}";
                fileContent += "\n";
            }
            try
            {
                StreamWriter sw = File.CreateText($"{directorySpecies}\\{Species}");
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
            StreamReader sr = new StreamReader($"{directorySpecies}\\{Species}");
            string line = string.Empty;
            line = sr.ReadLine();
            while(line != null)
            {
                Animall animall = new Animall();
                string[] animallData = line.Split(';');
                animall.Id = Convert.ToInt32(animallData[0] ) ;
                animall.Species = animallData[1];
                animall.Name = animallData[2];
                animall.Race = animallData[3];
                animall.Pet = animallData[4];

                DataSet.Animalls.Add(animall);

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
            int tam = DataSet.Animalls.Count;
            if( tam > 0)
                return DataSet.Animalls[tam - 1].Id +1;
            else
                return 1;
    
            
        }
    }
}