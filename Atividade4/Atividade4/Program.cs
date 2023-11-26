using System;

namespace Atividade4
{

    class Atv4
    {

        public static void Main(string[] args)
        {
            string PalavraPa = "A Sacada da Casa";
            //Aqui eu declaro uma string PalavraPa recebebendo o palindromo ai o usuario pode digitar qualquer palavra
            if (SNPalindromo(PalavraPa))
                //Aqui ele vai vê se a função SNPalindromo retorna verdadeiro ou falso de acordo com a plavra inserida
            {
                Console.WriteLine("A palavra " + PalavraPa + " é um palíndromo.");
                //caso ele retorve verdadeiro vai apresentar essa frase
            }
            else
            {
                Console.WriteLine("A palavra " + PalavraPa + " não é um palíndromo.");
                //caso ele retorve falso vai apresentar essa frase
            }
        }

        static bool SNPalindromo(string PalavraAjust)
           //Esse método SNPalindromo recebe uma palavra como parâmetro e
           //retorna caso seja  verdadeiro ele vai retornar que é um palindromo, e falso caso contrário.

        {
            PalavraAjust = Ajustar(PalavraAjust);
            // Aqui ele vai acessar a função ajustar, e vai remover caso tenha espaço e letras maiusculas
            // tornando a comparação insensível a maiúsculas/ minúsculas.



            return PalavraAjust == InvertPalavra(PalavraAjust);
            //Aqui ele vai acessar uma função que vai inverter as letras e verificar se retorna a palavra invertida
            //caso a palavra for igual à sua versão invertida(um palíndromo), e false caso contrário.


        }
        static string Ajustar(string pala)
        //Aqui eu declaro o método Ajustar, que recebe o PalavraAjust como parâmetro,
        //e remove todos os espaços e converte para minúsculas.

        {
            return pala.Replace(" ", "").ToLower();
                //Retorna o texto sem espaços e convertido em minúsculas.

        }

        static string InvertPalavra(string PalaInvertida)
        //Declaro ométodo InvertPalavra, que recebe PalavraAjust como parâmetro e retorna a palavra invertida invertido.

        {
            char[] Arletras = PalaInvertida.ToCharArray();
            //Aqui ele vai pegar PalaInvertida e vai converter em um array de caracteres

            Array.Reverse(Arletras);
//Inverte o array de caracteres.

            return new string(Arletras);
          //E ele cria uma nova string para poder retornar o array invertido

        }
    }

}