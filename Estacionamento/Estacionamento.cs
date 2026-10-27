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

        if(p.Length < 7 || p.Length > 7) 
        /// verifica na função para o usuario escrever novamente o nome da placa
        /// modificar variavel que guarda placa de carro para banco de dados....
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
        for(int i=0; i < this.Carros.Length; i++)
        {
            Console.WriteLine($"Vaga número {i} " + this.Carros[i]+" \n");
        
        }
        Console.WriteLine("Precione qualquet tecla para voltar ao menu;");
            Console.ReadKey();

    }

    private void AdicionarCarro(string carro)
    {
        bool guardado = false;
        Console.Clear();
        Console.WriteLine("Digite o nome do proprieta ");
            carro = Console.ReadLine();

        for(int i = 0; i < Carros.Length; i++)
        { 
       

            if(this.Carros[i] == null)
            {
                this.Carros[i] = carro;
                guardado = true;

                break;
            }
        }
        
            if(guardado == false)
        {
            Console.Write("Todas as vagas estão cheias \n");
            Console.Write("Precione qualquer tecla");    
                Console.ReadKey();

        }
        else
        {
            Console.WriteLine("Carro adicionado !!!\n");
            Console.WriteLine("Precione qualquer tecla...");
                Console.ReadKey();
        }
        
    }

}