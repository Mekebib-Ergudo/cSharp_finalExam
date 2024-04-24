using System;
using System.Collections.ObjectModel;

namespace cSharp_FInal_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello Git");

            // Example usage of GenericClass
            GenericClass<int> genericClass = new GenericClass<int>(5);
            genericClass.Add(1);
            genericClass.Add(2);
            genericClass.Add(3);

            var numbers = genericClass.GetNumbers(genericClass.GetCollection());
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }

    public class GenericClass<T>
        where T : struct 
    {
        private Collection<T> _collection;

        public GenericClass(int number)
        {
            _collection = new Collection<T>();
        }

        public void Add(T value)
        {
            _collection.Add(value);
        }

        public T[] GetNumbers(Collection<T> collections)
        {
            T[] numbers = new T[collections.Count];
            int i = 0;
            foreach (T value in collections)
            {
                numbers[i++] = value;
            }
            return numbers;
        }

        public Collection<T> GetCollection()
        {
            Collection<T> collection = new Collection<T>();

            for (int i = _collection.Count - 1; i >= 0; i--)
            {
                collection.Add(_collection[i]);
            }
            return collection;
        }
    }
}
