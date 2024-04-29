using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_types__Home_task_.Modes
{
    public class Person
    {
        private static int nextID=1;
        public  int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Id = nextID++;
        }

    }
}
