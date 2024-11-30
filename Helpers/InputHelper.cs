using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Helpers
{
    /// <summary>
    /// Вспомогательный класс для ввода данных различных типов.
    /// </summary>
    public static class InputHelper
    {
        /// <summary>
        /// Запрашивает у пользователя ввод целого числа.
        /// </summary>
        /// <param name="value">Сообщение для запроса.</param>
        /// <returns>Целое число, введенное пользователем.</returns>
        public static int GetInt(string value)
        {
            int result = 0;
            Console.Write("{0} {1}: ", subMessage, value);
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("{0} {1}: ", subMessage, value);
            }
            return result;
        }

        /// <summary>
        /// Запрашивает у пользователя ввод денежного значения (тип `decimal`).
        /// </summary>
        /// <param name="value">Сообщение для запроса.</param>
        /// <returns>Десятичное число, введенное пользователем.</returns>
        public static decimal GetDecimal(string value)
        {
            decimal result = 0;
            Console.Write("{0} {1}: ", subMessage, value);
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("{0} {1}: ", subMessage, value);
            }
            return result;
        }

        /// <summary>
        /// Запрашивает у пользователя ввод булевого значения ("True" или "False").
        /// </summary>
        /// <param name="value">Сообщение для запроса.</param>
        /// <returns>Булевое значение, введенное пользователем.</returns>
        public static bool GetBoolean(string value)
        {
            bool result = false;
            Console.Write("{0} {1}: ", subMessage, value);
            while (!bool.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("{0} {1}: ", subMessage, value);
            }
            return result;
        }

        /// <summary>
        /// Запрашивает у пользователя ввод непустой строки.
        /// </summary>
        /// <param name="value">Сообщение для запроса.</param>
        /// <returns>Непустая строка, введенная пользователем.</returns>
        public static string GetString(string value)
        {
            string result = string.Empty;
            Console.Write("{0} {1}: ", subMessage, value);
            while (string.IsNullOrWhiteSpace(result = Console.ReadLine()))
            {
                Console.Write("{0} {1}: ", subMessage, value);
            }
            return result;
        }

        /// <summary>
        /// Запрашивает у пользователя ввод корректной даты.
        /// </summary>
        /// <param name="value">Сообщение для запроса.</param>
        /// <returns>Дата, введенная пользователем.</returns>
        public static DateOnly GetDate(string value)
        {
            DateOnly dateOnly = new();
            Console.Write("{0} {1}: ", subMessage, value);
            while (!DateOnly.TryParse(Console.ReadLine(), out dateOnly))
            {
                Console.Write("{0} {1}: ", subMessage, value);
            }
            return dateOnly;
        }
    }

}
