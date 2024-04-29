using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_types__Home_task_.Modes
{
    public class CustomCollection<T> where T : Person
    {
        private T[] array = new T[0];

        public void Add(T element)
        {
            Array.Resize(ref array, array.Length + 1);
            array[^1] = element;
            Console.WriteLine("Employee added sucesfully )");
        }

        public T GetEmployeeById(int id)
        {
            foreach (T item in array)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null; 
        }


        public T[] GetAll()
        {
            return array;
        }
    }

}
