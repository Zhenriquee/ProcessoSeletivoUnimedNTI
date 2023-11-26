using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    //aqui eu estou criando uma classe no que representa um no da arvore
    //no caso uma bolinha onde o numero vai entrar
    public class No
    {
        public int ValorRaiz;
        public No NoEsquerda, NoDireita;

        // Esse Construtor chama ele mesmo para poder inicializa um nó com um valor específico
        // Pois para poder surgir um novo no é necessario criar uma nova variavel
        // valorRaiz e NoEsquerda, NoDireita para que caso haja outros valores subsequentes 
        // eles ocupem o lote NoEsquerda ou NoDireita
        public No(int valorRaiz)
        {
            ValorRaiz = valorRaiz;
            NoEsquerda = NoDireita = null;
        }
    }
}
