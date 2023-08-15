using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_EM_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float pagamento, valor, troco;
            int menu;

            Console.WriteLine("Menu: ");
            Console.WriteLine("1- Média de 3 numeros");
            Console.WriteLine("2- Troco de Compra");
            Console.WriteLine("3- Conversão de Temperatura");
            Console.Write("Escolha a Opção: ");
            menu = int.Parse(Console.ReadLine());  
            
            if (menu == 1) 
            {

                float a, b, c;
                float soma, media;

                Console.WriteLine("Digite o 1 numero: ");
                a= float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2 numero: ");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 3 numero: ");
                c = float.Parse(Console.ReadLine());

                soma = a+b+c;
                media = soma / 3;

                Console.WriteLine("O valor da média é:" + media );

              
            } else if (menu == 2)
            {
                Console.WriteLine("Digite o valor total da compra: ");
                valor = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor pago pelo cliente: ");
                pagamento = float.Parse(Console.ReadLine());

                if ( valor > pagamento ) 
                {
                    Console.WriteLine("O valor do pagamneto é insuficiente para concluir a compra: ");
                }
                else
                {
                    troco = pagamento - valor;
                    Console.WriteLine("O valor do seu troco é: R$" +  troco );
                }
            }
            else
            {
                float c, f;

                Console.WriteLine("Digite a temperatura em Celsius: ");
                c = float.Parse(Console.ReadLine());

                f = c * 9 / 5 + 32;
                Console.WriteLine("A temperatura em Fahrenheit é " + f );
            }




            Console.ReadKey();  



        }
    }
}
