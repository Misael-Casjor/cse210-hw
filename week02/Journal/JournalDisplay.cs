using System.IO;
public class Loader
{
   public static string ReadFromFile()
     {
     Console.WriteLine("Readig file");
     string filename = "Save.txt";
     string [] all = System.IO.File.ReadAllLines(filename);
     return string.Join("\n", all);
     }
}