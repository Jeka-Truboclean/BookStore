using BookStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class MenuOption : IShow<int>
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int Show()
        {
            Console.WriteLine($"{Id}: {Value}");
            return Id;
        }
    }
}
