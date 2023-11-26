using System;

namespace Atividade1
{
    class Atividade1
    {
        static void Main(string[] args)
{
            quantinumero(15);
    }

static void quantinumero(int n)
{
    int pmNum = 0,segNum = 1;
 Console.WriteLine("Os primeiros 15 números da sequência de Fibonacci:");

    for (int i = 0; i < n; i++)
    {
        Console.Write(pmNum + ", ");

        int resultf = pmNum + segNum;
            pmNum = segNum;
            segNum = resultf;
    }
}
}
}