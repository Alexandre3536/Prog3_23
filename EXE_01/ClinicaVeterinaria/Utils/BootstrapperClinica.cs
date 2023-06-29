using ClinicaVeterinaria.Data;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Utils
{
    public static class BootstrapperClinicas
    {
        public static void ChargeClinicas()
        {
            var c1 = new Clinica{
                Id=1,
                Name = "Bortoli",
                Telefone="(00)0000-0000",
                Endereco="Rua do Salto",
                Bairro="Salto",
                Numero = 01

            };
            DataSet.Clinicas.Add(c1);

            DataSet.Clinicas.Add(
                new Clinica{
                    Id=2,
                    Name = "Veloso",
                    Telefone="(00)0000-0001",
                    Endereco="Rua do Salto",
                    Bairro="Salto",
                    Numero = 02
                }
            );

          DataSet.Clinicas.Add(
                new Clinica{
                    Id=3,
                    Name = "Pet Shop",
                    Telefone="(00)0000-0002",
                    Endereco="Rua do Salto",
                    Bairro="Salto",
                    Numero = 03
                }
            );


        }
    }
}