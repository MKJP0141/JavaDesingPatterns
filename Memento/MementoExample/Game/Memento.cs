using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;

namespace MementoExample.Game
{
    [DataContract]
    public class Memento
    {
        int _money;
        List<string> _fruits;

        public Memento(int money)
        {
            _money = money;
            _fruits = new List<string>();
        }

        [DataMember]
        public int Money
        {
            get => _money;
            private set { _money = value; }
        }

        [DataMember]
        internal List<string> Fruits
        {
            get => _fruits;
            private set { _fruits = value; }
        }

        internal void AddFruits(string fruit)
        {
            _fruits.Add(fruit);
        }

        public void Serialize()
        {
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("memento.dat", settings))
            {
                var serializer = new DataContractSerializer(this.GetType());
                serializer.WriteObject(writer, this);
            }
        }

        public static Memento Deserialize()
        {
            using (var reader = XmlReader.Create("memento.dat"))
            {
                var serializer = new DataContractSerializer(typeof(Memento));
                return serializer.ReadObject(reader) as Memento;
            }
        }
    }
}