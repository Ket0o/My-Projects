using Employees.Model.Employees;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Model
{
    /// <summary>
    /// Класс реализует сортировку данных.
    /// </summary>
    public static class Sorting
    {
        /// <summary>
        /// Проводит сортировку коллекции рабочих по полному имени.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/></param>
        /// <returns>Возвращает отсортированную коллекцию рабочих.</returns>
        public static List<Employee> SortedEmployees(List<Employee> employees)
        {
            var sortedListEmployees = from employee in employees
                                      orderby employee.FullName
                                      select employee;

            return sortedListEmployees.ToList();
        }
    }
}
