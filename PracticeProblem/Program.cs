namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopAgain = true;
            while (loopAgain)
            {
                Console.WriteLine("\n1.NLog\n2.Dictionary\n3.ArrayList\n4.Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first number");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        int y = Convert.ToInt32(Console.ReadLine());
                        NLog.Addition(x, y);
                        break;
                    case 2:
                        Dictionary dictionary = new Dictionary();
                        dictionary.AddElements();
                        break;
                    case 3:
                        ArryList arryList = new ArryList();
                        arryList.DeleteeArray();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    case 5:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}