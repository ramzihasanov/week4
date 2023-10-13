using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Worker
    {   private byte _experence;
        private string _workerCode;
        public string Name { get; set; }

        public string Surname { get; set; }
        public Worker(string name,string surname)
        {
            Name = name;
            Surname = surname;
            _workerCode = (char.ToLower(Name[0]) + char.ToLower(Surname[0])).ToString();
        }
       
        
        public byte Experience { get=>_experence; set { if (value > 0) _experence = value; } }

    }
}
