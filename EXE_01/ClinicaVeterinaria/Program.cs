﻿using ClinicaVeterinaria.Views;
using ClinicaVeterinaria.Utils;

/*
    Programa para leitura de dados de pessoas e exportação em arquivo.txt

*/
BootstrapperMedicos.ChargeMedicos();
BootstrapperAnimal.ChargeAnimais();
BootstrapperClinicas.ChargeClinicas();


int option = 0;

do{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("1-Médicos");
    Console.WriteLine("2-Animais");
    Console.WriteLine("3-Clínicas");

    option = Convert.ToInt32( Console.ReadLine());

    switch(option)
    {
        case 1 :
            Console.WriteLine("OPÇÃO CLÍNICA VETERINÁRIA");
            MedicoView medicoView = new MedicoView();
        break;

        case 2 :
            Console.WriteLine("OPÇÃO CLÍNICA VETERINÁRIA");
            AnimalView animalView = new AnimalView();
        break;

        case 3 :
            Console.WriteLine("OPÇÃO CLÍNICA VETERINÁRIA");
            ClinicaView clinicaView = new ClinicaView();
        break;
    
    }

}
while(option > 0);
