namespace PracticeProblem
{
    internal class Dictionary
    {
        public void AddElements()
        {
            //creating dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();

            //adding key value elements in dictionary
            dict.Add(1, "First");
            dict.Add(2, "Second");
            dict.Add(3, "Third");
            dict.Add(4, "Fourth");

            //fetching or printing data
            foreach (KeyValuePair<int, string> ele in dict)
            {
                Console.WriteLine("Key is " + ele.Key + " Value is " + ele.Value);
            }

            //update dictionary
            Console.WriteLine("\nEnter key to update value");
            int key = Convert.ToInt32(Console.ReadLine());
            if (dict.ContainsKey(key))
            {
                dict[key] = "Updated";
            }
            else
            {
                Console.WriteLine("Key is not found");
            }
            foreach (KeyValuePair<int, string> eee in dict)
            {
                Console.WriteLine("Key is " + eee.Key + " Value is " + eee.Value);
            }

            //delete 
            Console.WriteLine("\nEnter key to delete");
            int key2 = Convert.ToInt32(Console.ReadLine());
            if (dict.ContainsKey(key2))
            {
                dict.Remove(key2);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            foreach (KeyValuePair<int, string> ee in dict)
            {
                Console.WriteLine("Key is " + ee.Key + " Value is " + ee.Value);
            }
        }
    }
}
