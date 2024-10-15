using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Helpers
{
    internal class ConsoleHelper
    {
        public static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine 18, int optionsPerline 3, int startX1, int startY = 1)
        {
            int currentSelection = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(userEnum.GetType()).Length;
            do
            {
                Console.Clear();
                if (currentSelection >= length)
                {
                }
                currentSelection -;
                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(startX + (i optionsPerLine) spacingPerLine, startY + 1 / optionsPerLine);
                if (i == currentSelection)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(Enum.Parse(userEnum.GetType(), i.ToString()));
                Console.ResetColor();
                key Console.ReadKey(true).Key;
                } while ();
            }
        }
  }
