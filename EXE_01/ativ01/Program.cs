namespace ativ01.classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[] {
            new Manager()
            {
                Name = "Alexandre de Bortoli",
                DateOfBirth = new DateTime(1991, 08, 09),
                Gender = "Masculino",
                HireDate = new DateTime(2010, 8, 18),
                Department = "Vendas"
            },
            new Supervisor()
            {
                Name = "Paula Moraes",
                DateOfBirth = new DateTime(1990, 10, 11),
                Gender = "Feminino",
                Team = "Supervisora",
                Shift = "Diurno"
                
            },
            new Worker()
            {
                Name = "Maria Fernanda",
                DateOfBirth = new DateTime(1995, 7, 8),
                 
                JobTitle = "Atendente",
                Salary = 1150.00m
            },
            new Manager()
            {
                Name = "Glória Garcia",
                DateOfBirth = new DateTime(1990, 8, 7),
                Gender = "Feminino",
                HireDate = new DateTime(2010, 6, 1),
                Department = "Gerente"
            },
            new Worker()
            {
                Name = "Natieli Nunes",
                DateOfBirth = new DateTime(1990, 8, 12),
                Gender = "Feminino",
                JobTitle= "Operadora de Produção",
                Salary = 1250.00m
            }
            };

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}:");
                Console.WriteLine($"Nome: {people[i].Name}");
                Console.WriteLine($"Data de nascimento: {people[i].DateOfBirth.ToShortDateString()}");
                Console.WriteLine($"Gênero: {people[i].Gender}");

                if (people[i] is Manager)
                {
                    Manager manager = (Manager)people[i];
                    Console.WriteLine($"Data de contratação: {manager.HireDate.ToShortDateString()}");
                    Console.WriteLine($"Departamento: {manager.Department}");
                }
                else if (people[i] is Supervisor)
                {
                    Supervisor supervisor = (Supervisor)people[i];
                    Console.WriteLine($"Time: {supervisor.Team}");
                    Console.WriteLine($"Turno: {supervisor.Shift}");
                }
                else if (people[i] is Worker)
                {
                    Worker worker = (Worker)people[i];
                    Console.WriteLine($"Cargo: {worker.JobTitle}");
                    Console.WriteLine($"Salário: {worker.Salary}");
                }

                Console.WriteLine();
            }
        }
    }
}