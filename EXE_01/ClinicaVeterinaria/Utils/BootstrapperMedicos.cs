using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Utils
{
    public static class BootstrapperMedicos
    {
        public static void ChargeMedicos()
        {
            var c1 = new Medico{
                Id=1,
                FirstName="Alexandre",
                LastName="De Bortoli",
                CPF="000.000.000-00",
                Email = "alexandre.debortoli26@gmail.com"
            };
            DataSet.Medicos.Add(c1);

            DataSet.Medicos.Add(
                new Medico{
                    Id=2,
                    FirstName="Maria",
                    LastName="Silva",
                    CPF="000.000.000-01",
                    Email = "maria@silva.com"
                }
            );

            DataSet.Medicos.Add(
                new Medico{
                    Id=3,
                    FirstName="Agnaldo",
                    LastName="Timóteo",
                    CPF="000.000.000-02",
                    Email = "agnaldo@timoteo.com"
                }
            );


        }
    }
}