using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.TOOLS
{
    class JsonSerialization
    {
        public JsonSerialization()
        {

        }

        public JsonSerialization(string Path)
        {
            FilePath = Path;
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        /// Convert Employer List to JSON string List
        /// </summary>
        /// <param name="Employer"></param>
        /// <returns></returns>
        public void Serialize(BindingList<Employer> list)
        {
            TextWriter tw = new StreamWriter(FilePath);

            foreach (var employer in list)
            {
                tw.Write(JsonConvert.SerializeObject(employer));
            }
        }

        /// <summary>
        /// Convert JSON List to Employer List
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public BindingList<Employer> StringsToEmployers()
        {
            List<string> allLinesText = File.ReadAllLines(FilePath).ToList();
            BindingList<Employer> _list = new BindingList<Employer>();
            foreach (var row in allLinesText)
            {
                _list.Add((Employer) JsonConvert.DeserializeObject<Employer>(row).Clone());
            }

            return _list;
        }
    }
}
