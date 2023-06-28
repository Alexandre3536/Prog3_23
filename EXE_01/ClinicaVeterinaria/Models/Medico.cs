namespace ClinicaVeterinaria.Models
{// Início do escopo do Namespace
    public class Medico
    {//Início do escopo da classe
        public int Id {get; set;}
        public string? FirstName { get;set;}
        public string? LastName { get;set;}

        public string? CPF {get;set;}

        public string? Email {get;set;}
    // Os métodos construtores são reponsáveis por instanciar uma variável do tipo especificado pela classe
    //A regra é de que o construtor tenha o mesmo nome da classe 
        public Medico()
        {

        }

    //método sempre utiliza parenteses ()
        public Medico(int id, string? firstName, string? lastName, string? cPF, string? email)
        { // Início do escopo deste método
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Email = email;
        } //Fim do escopo deste método
    }// Fim do escopo da classe
}// Fim do escopo do Namespace