using System.Text;

namespace SCP_7777
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Input operation type [ t (To) / f (From) / q (Quit)].");
                char keyChar = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (keyChar == 't')
                {
                    To();
                }
                else if (keyChar == 'f')
                {
                    From();
                }
                else if (keyChar == 'q')
                {
                    break;
                }
            }
        }

        static void To()
        {
            Console.WriteLine("Enter the text to convert.");
            string ascii = Console.ReadLine()!;

            byte[] textBytes = Encoding.ASCII.GetBytes(ascii);

            string output = string.Join("0", textBytes.Select(b => new string('7', b)));

            Console.WriteLine(output);
        }

        static void From()
        {
            Console.WriteLine("Input the SCP Text.");
            string SCPText = Console.ReadLine()!;

            string output = Encoding.ASCII.GetString(SCPText.Split('0').Select(x => (byte)x.Length).ToArray());

            Console.WriteLine(output);
        }
    }
}
