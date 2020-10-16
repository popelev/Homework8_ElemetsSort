using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.TOOLS
{
    public class XmlSerialization
    {
        XmlSerialization(){}

        public XmlSerialization(string Path)
        {
            FilePath = Path;
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        // получаем поток, куда будем записывать сериализованный объект
        public void Serialize( BindingList<Employer> employers)
        {
            FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);

            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Employer>));

            formatter.Serialize(fs, employers);
        }

        // десериализация
        public BindingList<Employer> Deserialize()
        {
            FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);

            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Employer>));

            return (BindingList<Employer>)formatter.Deserialize(fs);
        }

    }
}
