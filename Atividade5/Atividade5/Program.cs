using System;

namespace Atividade5 {


    class Atv5
    {

        static void Main(string[] args)
        {
            //Estou criando uma instancia da classe ArvoreBinaria
            ArvoreBinaria arvore = new ArvoreBinaria();


                // Aqui estou criando um Array com os numeros para inserir na arvore
                // que inicializa a árvore com os números de 1 a 5
                int[] ArNum = { 3, 2, 4, 1, 5 };
                foreach (var num in ArNum)
                {
                    arvore.InsereArvore(num);
                }
        //aqui estou chamando o metodo ordem para retornar a arvore binaria em ordem 
           arvore.Organizar(arvore.RaizArmazenaV);

        }
    }
}