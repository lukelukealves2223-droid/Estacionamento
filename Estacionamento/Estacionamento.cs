using System;
using System.Dynamic;
public class Estacionamento
{
    private string[] Placacarro {set; get;}
    public string[] Carros {set; private get;} = new string[5];


    public void VerificadorPlaca(string placa, bool x)
    {

        if(placa.Length < 7)
        {
            Console.WriteLine("Esse modelo de placa não é valido");
                x = true; /// verifica na função para o usuario escrever novamente o nome da placa
        }
        else
        {
            Console.WriteLine("Placa Aprovada!");
            Console.WriteLine("Precione qualquer teclar...");
                Console.ReadKey();
            
            placa = string.Empty;
            AdicionarCarro(placa);
            
            
        }
    }

    public void VerificarCarros()
    {
        for(int i=0; i < Carros.Length; i++)
        {
            Console.WriteLine(Carros[i]+" \n");
            Console.WriteLine("Precione qualquet tecla para voltar ao menu;");
            Console.ReadKey();
            break;
        }
    }

    private void AdicionarCarro(string carro)      //// REQUER AJUSTE //////////
    {
        
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