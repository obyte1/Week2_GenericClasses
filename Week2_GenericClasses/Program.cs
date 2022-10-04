using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_GenericClasses.Classess;

namespace Week2_GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLis<string> name = new LinkedLis<string>();
            Console.WriteLine("LINKEDLIST RESULT");
            Console.WriteLine();
            name.Add("ONYEKACHI");
            name.Add("PEACE");
            name.Add("VERA");
            name.Add("KACHI");
            name.Add("OLUFEM");

            Console.WriteLine("NAMES IN THE LIST ARE: ");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"THE INDEX OF VERA IS: {name.Indexer("VERA")}");
            Console.WriteLine($"THE TOTAL MEMBER COUNT IN THE NAME LIST IS: {name.Count}");
            Console.WriteLine($"IS \"KACHI\" IN THE LIST OF NAMES? : {name.Checks("KACHI")}");
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("##############################################################################");

            Console.ReadLine();


            /*

            StackLib<string> stack = new StackLib<string>();
            Console.WriteLine("STACK RESULT");
            Console.WriteLine();
            stack.StackPush("INNOCENT");
            stack.StackPush("ESTHER");
            stack.StackPush("EZE");
            stack.StackPush("RICHARDS");
            stack.StackPush("OBUTE");

            Console.WriteLine("MEMBERS OF THE STACK ARE: ");
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine($"STACK SIZE BEFORE POPING IS: {stack.StackArraySize()}");
            Console.WriteLine($"IS THE STACK EMPTY? True/False: {stack.StackIsEmpty()}");

            stack.StackPop();
            Console.WriteLine($"STACK SIZE AFTER POPING: {stack.StackArraySize()}");
            Console.WriteLine($"TOP VALUE IN THE STACK IS: {stack.StackPeek()}");
            Console.WriteLine($"IS STACK EMPTY? True/False: {stack.StackIsEmpty()}");
            Console.WriteLine();
            Console.WriteLine("############################################################################");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");




            Queue<string> queues = new Queue<string>();
            Console.WriteLine("QUEUE RESULT");
            Console.WriteLine();
            queues.QEnqueue("A");
            queues.QEnqueue("B");
            queues.QEnqueue("C");
            queues.QEnqueue("D");
            queues.QEnqueue("E");
            queues.QEnqueue("F");
            queues.QEnqueue("G");

            foreach (var item in queues)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"SIZE OF THE QUEUE IS: {queues.Qsize()}");
            Console.WriteLine($"ITEM REMOVED(DQUEUED) is : {queues.QDequeue()}");
            Console.WriteLine($"IS QUEUE EMPTY? True/False: {queues.QueueIsEmpty()}");
            Console.WriteLine($"SIZE OF QUEUE AFTER DQUEUE: {queues.Qsize()}");

            Console.ReadLine(); */
        }
            
    }
}
