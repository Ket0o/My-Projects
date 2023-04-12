using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Класс реализует проверку валидации. 
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, чтобы значение типа int было положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="nameProperty">Название значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string nameProperty)
        {
            if (value < 0)
            {
                throw new ArgumentException($"the value of the {nameProperty} field must be positive");
            }
        }

        /// <summary>
        /// Проверяет, чтобы значение типа double было положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="nameProperty">Название значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, string nameProperty)
        {
            if (value < 0)
            {
                throw new ArgumentException($"the value of the {nameProperty} field must be positive");
            }
        }

        /// <summary>
        /// Проверяет находиться ли значение типа int в диапозоне от одного числа до другого.
        /// </summary>
        /// <param name="nameProperty">Название значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапозона.</param>
        /// <param name="max">Правая граница диапозона.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }

        /// <summary>
        /// Проверяет находиться ли значение типа double в диапозоне от одного числа до другого.
        /// </summary>
        /// <param name="nameProperty">Название значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапозона.</param>
        /// <param name="max">Правая граница диапозона.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }
    }
}
