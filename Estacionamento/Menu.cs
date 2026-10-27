using System;

public class Menu
{
    
public void Gerenciador()
{

bool continuar = true; /// laço que faz o menu inteiro se repetir ate o usuario dizer para parar
bool z = true;

 Estacionamento estacionamento = new Estacionamento();


    do{
    
    Console.Clear();

    Console.Write("==== MENU ESTACIONAMENTO  ===== \n");
    Console.WriteLine("Verificar 1\n Adicionar Carro 2\n Despachar Carro 3\n Verificar lucro 4\n");
    Console.WriteLine("Digite a opção: ");
        string esc = Console.ReadLine();

        switch (esc)
        {
            case "1":
                ///exibidor de carros no estacionamento
                estacionamento.VerificarCarros();
                    break;

            case "2":
                ///Adiciona carro
                estacionamento.VerificadorPlaca();
                    break;
                    
            case "3": break;        
        }        

    }while(continuar);
    
    }
}