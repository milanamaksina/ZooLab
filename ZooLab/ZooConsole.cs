
namespace ZooLab.Animals
{
    public class ZooConsole: IConsole
    {
        public List<string> Log { get; set; } = new List<string>();
        public void WriteLine(string message)
        {
            Log.Add(message);
            Console.WriteLine(message);
        }
    }
}
