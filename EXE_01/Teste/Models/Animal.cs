namespace ArqExercicios.Models
{// Início do escopo do Namespace
    public class Animal
    {//Início do escopo da classe
        public int Id {get; set;}
        public string? Species { get;set;}
        public string? Name { get;set;}

        public string? Race {get;set;}

        public string? Pet {get;set;}
    // Os métodos construtores são reponsáveis por instanciar uma variável do tipo especificado pela classe
    //A regra é de que o construtor tenha o mesmo nome da classe 
        public Animal()
        {

        }

    //método sempre utiliza parenteses ()
        public Animal(int id, string? species, string? name, string? race, string? pet)
        { // Início do escopo deste método
            Id = id;
            Species = species;
            Name = name;
            Race = race;
            Pet = pet;
        } //Fim do escopo deste método
    }// Fim do escopo da classe
}// Fim do escopo do Namespace