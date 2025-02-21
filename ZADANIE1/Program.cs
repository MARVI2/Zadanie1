namespace ZADANIE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = "C:\\Users\\bartl\\OneDrive\\Pulpit\\praktyki\\ZADANIE1\\ZADANIE1\\test_KOR_GAR.txt";
            int counter = 0;

            if (!File.Exists(path)) return;

            StreamReader sw = File.OpenText(path);
            string line;

            while(( line = sw.ReadLine()) != null){
                foreach(char letter in line)
                {
                    if (letter == 'a') counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
