using System;

namespace Atividade3 { 
class Atv3
{
    static void Main()
        {     
                
                int[] ArNum = { 1, 2, 6, 4, 11, 24, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            // Aqui estou criando um Array de numeros de 1 até 20     


            
            Console.Write("Digite o número que você está procurando: ");
                if (int.TryParse(Console.ReadLine(), out int Num))
                // aqui eu estou pedindo para o usuario digitar o numero inteiro,
                // se o numero for inteiro ele entra nessa condição
                {
                    int Pnum = Pvetor(ArNum, Num);
                //aqui eu estou declarando a variavel PosiçãoNumero como inteiro chamado a dunção Posição do vetor
                //que recebe o array que a gente criou no inicio ArNum e o numero que o usuario informou

                if (Pnum != -1)
                 //nesse if ele vai ve caso o numero seja valido ele vai entrar nessa condição
                    {
                    Console.WriteLine("Tendo em vista que o Indice começa sempre em 0 ");
                    Console.WriteLine("O número: "+ Num + " esta na posição: " + Pnum);
                    //se tudo tiver certinho ele vai entrar nessa condição retornando o numero e a posição
                    }
                    else
                    //caso o numero não esteja na lista ele vai entrar nessa condição
                    {

                        Console.WriteLine("O número: "+ Num + " não existe na lista.");
                    //informando que o numero informado não existe na lista
                    }
                }
                else
                // e essa condição é caso o usuario digite um valor invalido pois Num so recebe int
                {
                    Console.WriteLine("Por favor, digite um numero inteiro valido.");
                // informando que o numero informado não existe na lista
                }
            }

            static int Pvetor(int[] Lista, int NumSelec)
        //aqui eu declaro o método Pvetor, que realiza a busca na lista ordenada.

        {
            for (int i = 0; i < Lista.Length; i++)
                //Início do loop que percorre a lista.
                //tendo em mente que ele ta pegando a quantidade de vetores existentes na lista com o lista.Length

                {
                if (Lista[i] == NumSelec)
                //aqui ele compara e ve se o numero da lista é igual ao numero informado pelo usuario
                {
                    return i;
                    // quando ele achar o numero ele vai retornar i que é o indice.

                }
                else if (Lista[i] > NumSelec)
                // Caso o numero selecionado seja maior que o numero da lista ele vai parar.


                {
                    break;
                    //Sai do loop, pois o alvo não está na lista.
                    }
                }
                return -1;
            //e Caso o alvo não seja encontrado ele ira retorna -1 para entrar na condição da linha 23.
            }      
    }
}