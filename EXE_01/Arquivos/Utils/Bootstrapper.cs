using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id=1,
                FirstName="Alexandre",
                LastName="De Bortoli",
                CPF="000.000.000-00",
                Email = "alexandre.debortoli26@gmail.com"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id=2,
                    FirstName="Maria",
                    LastName="Silva",
                    CPF="000.000.000-01",
                    Email = "maria@silva.com"
                }
            );

            DataSet.Clients.Add(
                new Client{
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