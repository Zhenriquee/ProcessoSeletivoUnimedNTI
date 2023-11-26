using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;

namespace Atividade2
{
    class Atividade2
    {
        static void Main(string[] args)
        {
            int[] arNum = {12, 2, 8, 1, 3};
            //aqui eu crio um array que tem 5 numeros e coloquei o nome de
            //'arNum' que significa ArrayNumero 
           
            RetornoAr("Lista inicial", arNum);
            //Aqui eu chamo a função RetornoAr que significa retornoarArray
            //para exibir a lista antes de organizar ela.

            OrganizarAr(arNum);
            // Aqui eu chamo a  OrganizarAr que significa OrganizarArray
            // para organizar a lista.

            RetornoAr("Lista organizada do menor para o maior", arNum);
            // Aqui eu chamo a função novamente RetornoAr para exibir a lista ja organizada.

        }

        static void OrganizarAr(int[] ar)
        //Aqui eu declaro o método OrganizarAr, que recebe o arNum como parâmetro e
        //organiza usando o algoritmo Bubble Sort.

        {
            int TamAr = ar.Length;
            //Aqui eu vejo qual o tamanho do array, no caso quantos indices ele possui
            //usando o .Length tendo em mente que ele começa do 0

      for (int i = 0; i < TamAr - 1; i++)
      //Esse primeiro loop ele percorre todos os indices do array
 

            {
                for (int x = 0; x < TamAr - 1 - i; x++)
                    // Nesse segundo loop ele vai percorrer para saber a posição exata
                    // de cada indice.
                {
                    if (ar[x] > ar[x + 1])
                     //Aqui ele verifica se é necessario trocar de lugar os indices,
                     //Caso o primeiro indice seja maior que o segundo ele vai entrar na condição.
                    {
                        OrgaIndice(ref ar[x], ref ar[x + 1]);
                        //Aqui eu chamo a função OrgaIndice para organizar os valores dos indices.

                    }
                }
            }
        }

        static void OrgaIndice(ref int PrimeiroInd, ref int SegundoInd)
        //aqui eu declaro o metodo  OrgaIndice que vai receber o primeiro e o segundo indice
        //no caso seriam x e x+1 do if anterior na linha 49.

        {
            int Vtemp = PrimeiroInd;
            PrimeiroInd = SegundoInd;
            SegundoInd = Vtemp;
            //dessa maneira ele vai armazenar o primeiro valor na variavel Vtemp 
            //dai logo em seguida o primeiro valor vai ser substituido pelo segundo valo
            //e o segundo valor vai ser substituido pela variavel temporaria que é o antigo
            //primeiro valor, logo o menor valor vai ficar em primeiro e o maior em segundo
        }

        static void RetornoAr(string mensagem, int[] ArTratado)
        //aqui eu declaro o metodo RetornoAr, que recebe uma string 'mensagem' e os valores do array.
        {
            Console.WriteLine(mensagem + ": " + string.Join( ", ", ArTratado));
        //aqui eu vou tratar a informação dizendo concatenando a mensagem que vou receber
        //com a função string.Join que vai separar por virgula cada indice do meu vetor
        }
    }
}











