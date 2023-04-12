using ObjectOrientedPractics.Model;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс реализует сортировку данных.
    /// </summary>
    public static class Sorting
    {
        /// <summary>
        /// Проводит сортировку коллекции продуктов по наименовании.
        /// </summary>
        /// <param name="items">Коллекция класса<see cref="Item"/> /param>
        /// <returns>Возвращает отсортированную коллекцию продуктов.</returns>
        public static List<Item> SortedItems(List<Item> items)
        {
            var sortedListItems = from item in items
                                  orderby item.Name
                                  select item;

            return sortedListItems.ToList();
        }

        /// <summary>
        /// Проводит сортировку коллекции покупателей по полному имени.
        /// </summary>
        /// <param name="customers">Коллекция класса<see cref="Customer"/> /param>
        /// <returns>Возвращает отсортированную коллекцию покупателей</returns>
        public static List<Customer> SortedCustomers(List<Customer> customers)
        {
            var sortedListCostumer = from customer in customers
                                     orderby customer.FullName
                                     select customer;

            return sortedListCostumer.ToList();
        }
    }
}
