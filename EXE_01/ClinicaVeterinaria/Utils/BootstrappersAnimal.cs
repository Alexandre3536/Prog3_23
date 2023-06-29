using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Utils
{
    public static class BootstrapperAnimal
    {
        public static void ChargeAnimais()
        {
           
            var c1 = new Animall{
                Id=1,
                Species="Cachorro",
                Name="Scooby-doo",
                Race="Dogue Alemão",
                Pet = "Sim"
            };
            DataSet.Animalls.Add(c1);

            DataSet.Animalls.Add(
                new Animall{
                   Id=2,
                  Species="Cachorro",
                  Name="Muttley",
                  Race="Pitbull",
                  Pet = "Sim"
                }
            );
             DataSet.Animalls.Add(
                new Animall{
                   Id=3,
                  Species="Gato",
                  Name="Garfield",
                  Race="Persa",
                  Pet = "Sim"
                }
            );

          


        }
    }
}