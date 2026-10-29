using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
public class Estacionamento
{
    public string []? Placacarro {set; get;}
    public string[] Carros {set; private get;} = new string[5];


    public void VerificadorPlaca()
    {
       
        do{
        Console.Clear();    
        Console.WriteLine("Digite o numero da placa do carro: ");
            string p = Console.ReadLine().ToUpper();

        int totalnumero = p.Count(Char.IsDigit);
        int totaletra = p.Count(Char.IsLetter);

        if(p.Length < 7 || p.Length > 7 || totalnumero < 3 || totaletra < 4) 
        {
            Console.Clear();
            Console.WriteLine("   Esse modelo de placa não é valido, aperte qualquer tecla e digite novamamente... ");
                Console.ReadLine();

        }
        else
        {
            Console.Clear();
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
            if(this.Carros[i] == null)
            {
                 Console.Write("");

            }
            else
            {
            Console.WriteLine($"  {this.Carros[i]}  Vaga Nº {i} \n");
    
            }

        }
        Console.WriteLine("Precione qualquer tecla para voltar ao menu;");
            Console.ReadKey();

    }

    private void AdicionarCarro(string carro)
    {
        bool guardado = false;
        Console.Clear();
        Console.WriteLine("Digite o nome do proprietario: ");
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