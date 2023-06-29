namespace ClinicaVeterinaria.Models
{// Início do escopo do Namespace
    public class Clinica
    {//Início do escopo da classe
        public int Id {get; set;}
        public string? Name { get;set;}
        public string? Telefone { get;set;}

        public string? Endereco {get;set;}

        public string? Bairro {get;set;}
         public int? Numero {get;set;}
    // Os métodos construtores são reponsáveis por instanciar uma variável do tipo especificado pela classe
    //A regra é de que o construtor tenha o mesmo nome da classe 
        public Clinica()
        {

        }

    //método sempre utiliza parenteses ()
        public Clinica(int id, string? name, string? telefone, string? endereco, string? bairro, int numero)
        { // Início do escopo deste método
            Id = id;
            Name = name;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            Numero = numero;

        } //Fim do escopo deste método
        public string IdName => $"{this.Id} {this.Name}";


        public override string ToString()
        {
            return $"Id:{this.Id}; Name: {this.IdName} ";
        }




    }// Fim do escopo da classe
}// Fim do escopo do Namespace