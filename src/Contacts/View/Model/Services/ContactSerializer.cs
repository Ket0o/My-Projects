using Newtonsoft.Json;
using System;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Класс реализует сериализцаию и десериализацию данных.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Путь к – «Мои документы\Contacts\contacts.json».
        /// </summary>
        public static string MyDocumentsPath { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="contact">Контактные данные.</param>
        public static void Serialize(Contact contact)
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(
                    Path.GetDirectoryName(MyDocumentsPath));
            using (StreamWriter writer = new StreamWriter(MyDocumentsPath))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Объект типа <see cref="Contact"/>.</returns>
        public static Contact Deserialize()
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(MyDocumentsPath));
            Contact contact = new Contact();
            try
            {
                using (StreamReader reader = new StreamReader(MyDocumentsPath))
                {
                    contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd());
                }

                if (contact == null) contact = new Contact();
            }
            catch (FileNotFoundException e)
            {
                return contact;
            }

            return contact;
        }
    }
}