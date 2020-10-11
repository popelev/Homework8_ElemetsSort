using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.TOOLS
{
    public class XmlSerialization
    {
        XmlSerializer formatter = new XmlSerializer(typeof(Employer));
        FileStream fs = new FileStream("Employer.xml", FileMode.OpenOrCreate);

        // получаем поток, куда будем записывать сериализованный объект
        public void Serialize(FileStream fs, Employer employer)
        {
            formatter.Serialize(fs, employer);
        }

        // десериализация
        public void Deserialize(FileStream fs, Employer employer)
        {
            Employer newEmployer = (Employer)formatter.Deserialize(fs);
        }

    }
}
