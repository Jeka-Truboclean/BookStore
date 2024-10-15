using BookStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Helpers
{
    internal class ItemsHelper
    {
        /// <summary>
/// </summary>
/// <param name="canCancel">Для отмены/рагав>
/// <param name="items">Пункты менюс/рага
/// <param name="IsMenu">При значении True вывод кнопку назад/рагам>
/// <param name="message">Если не NULL, выводим сообщение перед отображением меню</рагат>
/// <param name="spacing PerLine">Количество отступов между столбиками</рагат>
/// <param name="optionsPerLine">Количество значений в одном столбике</рагам /// <param name="startX">Количество отступов с левой стороны консоли</рагам>
// <param name="startY">Количество отступов с верхней стороны консоли</рагам>
/ /// <returns></returns>
O references
public static int MultipleChoice<T>(bool canCancel, List<T> items, bool IsMenu false, string message = null, int spacingPerLine 18, int optionsPerLine 3, int startX = 1, int startY = 1) where T : IShow<int>, new()
        {
            //Если это стандартное меню,
            //добавляем в начало списка пункт "Back", для возвращения назад по меню.
            if (IsMenu)
            {
            }
            items.Insert(0, new T()
            {
                Id = 0,
                Value = [...Back]" });
            int currentSelection = 0;
            int currentId = 0;
            Consolekey key;
            Console.CursorVisible = false;
        }
        }
}
