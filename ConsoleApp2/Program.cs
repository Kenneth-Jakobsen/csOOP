namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library.AddBook();
            Console.WriteLine(Library.TotalBooks);
        }
    }
}
