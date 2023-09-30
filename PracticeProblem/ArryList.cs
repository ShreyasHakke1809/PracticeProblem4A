using System.Collections;

namespace PracticeProblem
{
    internal class ArryList
    {
        public void DeleteeArray()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(20);
            arrayList.Add("Shreyas");
            arrayList.Add(18f);
            arrayList.Add('k');

            foreach (var element in arrayList)
            {
                Console.WriteLine("Elements are " + element);
            }

            //update value
            Console.WriteLine("Update element at present index");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value >= 0 && value < arrayList.Count)
            {
                arrayList[value] = "update";
            }
            else
            {
                Console.WriteLine("Index out of range");
            }

            //updated arraylist

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }

            //delete

            Console.WriteLine("Delete element at present index");
            int valuee = Convert.ToInt32(Console.ReadLine());
            if (valuee >= 0 && valuee < arrayList.Count)
            {
                arrayList.RemoveAt(valuee);
            }
            else
            {
                Console.WriteLine("Index out of range");
            }

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
