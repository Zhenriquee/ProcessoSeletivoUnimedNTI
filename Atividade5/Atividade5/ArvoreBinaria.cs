using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class ArvoreBinaria
    {

        public No RaizArmazenaV;
        // Declaração da variável Raiz que vai armazenar o valor, que representa o nó raiz da árvore


        
        public void InsereArvore(int valor)
        //Esse método ele é responsavel por  inserir um valor na árvore
        {
            RaizArmazenaV = InserirRecursivo(RaizArmazenaV, valor);

        }

      //Esse metodo é responsavel por comparar os valores e decidir
      //se ele vai para o noEsquerda ou noDireita,
      //ele tambem é responsavel por criar um novo no direito e esquerdo
      //com o valor nulo para caso haja mais valores ele ja tenha lugar para ser armazenado
        private No InserirRecursivo(No no, int valor)
        {
            if (no == null)
            // Se o nó atual for nulo, ele vai cria um novo nó com o valor null
            {
                return new No(valor);
            }

            if (valor < no.ValorRaiz)
            // Se o valor a ser inserido é menor que o valor do nó atual, chama recursivamente à esquerda
            //nesse caso ele vai inserir o calor no noEsquerda
            {
                no.NoEsquerda = InserirRecursivo(no.NoEsquerda, valor);
            }
         
            else if (valor > no.ValorRaiz)
            // Se o valor a ser inserido é maior que o valor do nó atual, chama recursivamente à direita
            //nesse caso ele vai inserir o calor no noDireita

            {
                no.NoDireita = InserirRecursivo(no.NoDireita, valor);
            }
            return no;
        }

        // a Função Organizar serve para percorrer a árvore em ordem e imprimir os valores
        public void Organizar(No no)
        {
            if (no != null)
            //Verifica se o nó atual (no) não é nulo. Isso é importante para garantir que não estamos tentando percorrer um nó nulo,
            {
                Organizar(no.NoEsquerda);
                //Chama recursivamente a função Organizar para percorrer a subárvore à esquerda do nó atual.
                //Isso garante que todos os nós à esquerda do nó atual sejam visitados antes do próprio nó atual.
                Console.Write(no.ValorRaiz + ", ");
                //essa parte aqui ela serve para imprimir o valor e colocar uma virgula para separar os numeros
                Organizar(no.NoDireita);
                //Chama recursivamente a função Organizar para percorrer a subárvore à direita do nó atual.
                //Isso garante que todos os nós à direita do nó atual sejam visitados após o nó atual.
            }

        }
    }

}
