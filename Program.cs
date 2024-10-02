using System;
using System.ComponentModel;

namespace ListaDePresenca
{
    class Program
    {
        static void Main()
        {
            Name();
        }

        static void Name()
        {
            Console.WriteLine("Lista de presença de alunos");
            Console.WriteLine("Alunos: ");

            Queue<string> chamada = new Queue<string>();

            chamada.Enqueue("Angelo");
            chamada.Enqueue("Ganso");
            chamada.Enqueue("Neilton");
            chamada.Enqueue("Neymar");
            chamada.Enqueue("Marcos Leonardo");
            chamada.Enqueue("Robinho");
            chamada.Enqueue("Vanderlei");
            foreach (var obj in chamada)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("=================");
            
            
            
            for (int i = 0; i < chamada.Count; i++)
            {   
                string name1 = Console.ReadLine();
                if(chamada.Contains(name1))
                    Console.WriteLine("Presente\n----------");
                else{
                    Console.WriteLine("Faltou");
                }
            }


        }

        static void Comparar()
        {
            
        }

    }

}