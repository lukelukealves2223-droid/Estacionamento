using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
public class Estacionamento
{
    private string[] Placacarro {set; get;}
    public string[] Carros {set; private get;} = new string[5];


    public void VerificadorPlaca()
    {
       
        do{
        Console.Clear();    
        Console.WriteLine("Digite o numero da placa do carro: ");
            string p = Console.ReadLine();

        if(p.Length < 7 || p.Length > 7) /// verifica na função para o usuario escrever novamente o nome da placa
        {
            Console.WriteLine("Esse modelo de placa não é valido, aperte qualquer tecla e digite novamamente...");
                Console.ReadLine();

        }
        else
        {
            Console.WriteLine("Placa Aprovada!");
            Console.WriteLine("Precione qualquer teclar...");
                Console.ReadKey();
            
            p = string.Empty;
            AdicionarCarro(p);
            break; 
        }
        }while(true);
    }


    public void VerificarCarros() /// mostra a lista de carros
    {
        Console.Clear();
        for(int i=0; i < Carros.Length; i++)
        {
            Console.WriteLine(Carros[i]+" \n");
            Console.WriteLine("Precione qualquet tecla para voltar ao menu;");
            Console.ReadKey();
            break;
        }
    }

    private void AdicionarCarro(string carro)     /// requer ajuste pois não está adicionado masi de 2 carros na lista
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do carro que possa ser identificado: ");
            carro = Console.ReadLine();

        for(int i = 0; i < Carros.Length; i++)
        { 
       

            if(Carros[i] == null)
            {
                this.Carros[i] = carro;


                break;
            }
        }
        
        Console.WriteLine("Carro adicionado !!!\n");
        Console.WriteLine("Precione qualquer tecla...");
        Console.ReadKey();
        
        
    }

}