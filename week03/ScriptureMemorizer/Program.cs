using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        Reference _reference1 = new Reference("1Nephy", 3, 7);
        Scripture _chosen1 = new Scripture(_reference1, "7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        bool _check = _chosen1.IsCompletelyHidden();


        do
        {

            Console.WriteLine($"{_reference1} {_chosen1}");
            Console.ReadLine();

        } while (_check != true);


    }
}