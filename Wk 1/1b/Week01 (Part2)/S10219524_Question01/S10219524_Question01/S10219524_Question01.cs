// See https://aka.ms/new-console-template for more information
public class S10219524_Question01
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            string file = "PhoneDirectory.csv";
            string[] read = File.ReadAllLines(file);
            if (read.Length == 0)
            {
                string header = "Name,Number\n";
                File.WriteAllText(file, header);
            }
            if (name == "Exit")
            {
                for (int i = 0; i < read.Length; i++)
                {
                    string[] split = read[i].Split(',');
                    Console.WriteLine("{0,12} {1,12}", split[0], split[1]);
                }
                Environment.Exit(0);
            }
            else
            {
                Console.Write("Phone Number: ");
                string number = Console.ReadLine();
                string contacts = name + "," + number;
                string[] both = new string[] { contacts };
                File.AppendAllLines(file, both);
            }
        }
    }
}
