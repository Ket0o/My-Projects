using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace ViewModel.Services
{
    // TODO: почитать про DTO (data transfer object)
    /// <summary>
    /// Класс реализует сериализцаию и десериализацию данных.
    /// </summary>
    public static class ContactsSerializer
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
        /// <param name="contacts">Списко контактных данных.</param>
        public static void Serialize(ObservableCollection<ContactVm>? contacts)
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(
                    Path.GetDirectoryName(MyDocumentsPath));
            using (StreamWriter writer = new StreamWriter(MyDocumentsPath))
            {
                writer.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Список контактных данных.</returns>
        public static ObservableCollection<ContactVm>? Deserialize()
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(MyDocumentsPath));
            ObservableCollection<ContactVm>? contacts = new ObservableCollection<ContactVm>();
            try
            {
                using (StreamReader reader = new StreamReader(MyDocumentsPath))
                {
                    contacts = JsonConvert.
                        DeserializeObject<ObservableCollection<ContactVm>>(reader.ReadToEnd());
                }

                if (contacts == null) contacts = new ObservableCollection<ContactVm>();
            }
            catch (FileNotFoundException e)
            {
                return contacts;
            }

            return contacts;
        }
    }
}
