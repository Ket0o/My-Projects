using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using WpfContacts.ViewModel;

namespace WpfContacts.Model.Services
{
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
        public static void Serialize(ObservableCollection<ContactVM>? contacts)
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
        public static ObservableCollection<ContactVM>? Deserialize()
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(MyDocumentsPath));
            ObservableCollection<ContactVM>? contacts = new ObservableCollection<ContactVM>();
            try
            {
                using (StreamReader reader = new StreamReader(MyDocumentsPath))
                {
                    contacts = JsonConvert.
                        DeserializeObject<ObservableCollection<ContactVM>>(reader.ReadToEnd());
                }

                if (contacts == null) contacts = new ObservableCollection<ContactVM>();
            }
            catch (FileNotFoundException e)
            {
                return contacts;
            }

            return contacts;
        }
    }
}
