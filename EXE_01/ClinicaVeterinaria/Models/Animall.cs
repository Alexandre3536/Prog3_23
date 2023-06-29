namespace ClinicaVeterinaria.Models
{// Início do escopo do Namespace
    public class Animall
    {//Início do escopo da classe
        public int Id {get; set;}
        public string? Species { get;set;}
        public string? Name { get;set;}

        public string? Race {get;set;}

        public string? Pet {get;set;}
    // Os métodos construtores são reponsáveis por instanciar uma variável do tipo especificado pela classe
    //A regra é de que o construtor tenha o mesmo nome da classe 
        public Animall()
        {

        }

    //método sempre utiliza parenteses ()
        public Animall(int id, string? species, string? name, string? race, string? pet)
        { // Início do escopo deste método
            Id = id;
            Species = species;
            Name = name;
            Race = race;
            Pet = pet;
        } //Fim do escopo deste método

        public string SpeciesName => $"{this.Species} {this.Name}";


        public override string ToString()
        {
            return $"Id:{this.Id}; Pet: {this.SpeciesName} ";
        }

    }// Fim do escopo da classe
}// Fim do escopo do Namespace