using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_1
{
    class Account<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string GetInfo()
        {
            return $"{Num} {Name} {Balance}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));

            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
        }
    }
}
