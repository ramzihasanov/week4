using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Department
    {
        public string Name { get; set; }


        Worker[] Workers=Array.Empty<Worker>();
        public void AddWorker(Worker worker)
         {
            Array.Resize(ref Workers, Workers.Length + 1);
            Workers[^1] = worker;
        
         }

        public string SearchWorker(string name)
        {
            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].Name == name) { return Workers[i].Name; }
            }
            return null;
        }

        public void ShowAllWorkers()
        {
            for (int i = 0; i < Workers.Length; i++)
            {
                Console.WriteLine(Workers[i].Name);
            }
        }



    }


    
}
