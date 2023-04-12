using Employees.Model.Employees;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Employees.Model
{
    /// <summary>
    /// Класс реализует сериализцаию и десериализацию данных.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Путь к a AppData
        /// </summary>
        private static string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/></param>
        public static void Serialize(List<Employee> employees)
        {
            using (StreamWriter sw = new StreamWriter(AppDataPath + InitialConstants.SerializerResult))
            {
                sw.Write(JsonConvert.SerializeObject(employees));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию работников.</returns>
        public static List<Employee> Deserialize()
        {
            var employees = new List<Employee>();

            try
            {
                using (StreamReader sr = new StreamReader(AppDataPath + InitialConstants.SerializerResult))
                {
                    employees = JsonConvert.DeserializeObject<List<Employee>>(sr.ReadToEnd());
                }

                if (employees == null)
                {
                    employees = new List<Employee>();
                }
            }
            catch
            {
                return employees;
            }

            return employees;
        }
    }
}
