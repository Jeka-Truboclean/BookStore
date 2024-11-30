using BookStore.Interfaces;
using System;
using System.Collections.Generic;

namespace BookStore.Helpers
{
    internal class ItemsHelper
    {
        /// <summary>
        /// Позволяет выводить список элементов с возможностью выбора.
        /// </summary>
        /// <param name="canCancel">Позволяет отменить выбор с помощью клавиши Escape.</param>
        /// <param name="items">Список пунктов меню.</param>
        /// <param name="isMenu">Если True, добавляется пункт "Back" для возврата назад.</param>
        /// <param name="message">Сообщение, выводимое перед отображением меню.</param>
        /// <param name="spacingPerLine">Количество отступов между столбцами.</param>
        /// <param name="optionsPerLine">Количество значений в одной строке.</param>
        /// <param name="startX">Отступ с левой стороны консоли.</param>
        /// <param name="startY">Отступ с верхней стороны консоли.</param>
        /// <returns>Идентификатор выбранного элемента.</returns>
        public static int MultipleChoice<T>(bool canCancel, List<T> items, bool isMenu = false, string message = null,
            int spacingPerLine = 18, int optionsPerLine = 3, int startX = 1, int startY = 1) where T : IShow<int>, new()
        {
            // Если это стандартное меню, добавляем пункт "Back" для возврата назад.
            if (isMenu)
            {
                items.Insert(0, new T
                {
                    Id = 0,
                    Value = "[...Back]"
                });
            }

            int currentSelection = 0;
            int currentId = 0;
            ConsoleKey key;
            Console.CursorVisible = false;

            do
            {
                Console.Clear();

                // Если передано сообщение, выводим его.
                if (message != null)
                {
                    Console.WriteLine(message);
                }

                // Проверка, что текущий выбор не превышает количество элементов.
                if (currentSelection >= items.Count)
                {
                    currentSelection--;
                }

                // Отрисовка пунктов меню.
                for (int i = 0; i < items.Count; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Подсветка выбранного пункта.
                        currentId = items[i].Id;
                    }

                    Console.Write(items[i].Value);
                    Console.ResetColor();
                }

                // Обработка ввода пользователя.
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (currentSelection % optionsPerLine > 0)
                        {
                            currentSelection--;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (currentSelection % optionsPerLine < optionsPerLine - 1)
                        {
                            currentSelection++;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (currentSelection >= optionsPerLine)
                        {
                            currentSelection -= optionsPerLine;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (currentSelection + optionsPerLine < items.Count)
                        {
                            currentSelection += optionsPerLine;
                        }
                        break;

                    case ConsoleKey.Escape:
                        if (canCancel)
                        {
                            return 0; // Отмена выбора.
                        }
                        break;
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            Console.WriteLine("\n");
            return currentId; // Возврат идентификатора выбранного элемента.
        }
    }
}
