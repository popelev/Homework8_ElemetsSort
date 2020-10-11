using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WpfNetCore_HW8.Model;

namespace WpfNetCore_HW8.TOOLS
{
    class JsonSerialization
    {
        public JsonSerialization()
        {

        }

        /// <summary>
        /// Convert Employer List to JSON string List
        /// </summary>
        /// <param name="Employer"></param>
        /// <returns></returns>
        public List<string> EmployersToStrings(BindingList<Employer> list)
        {
            List<string> _list = new List<string>();

            foreach (var employer in list)
            {
                _list.Add(JsonConvert.SerializeObject(employer));
            }

            return _list;
        }

        /// <summary>
        /// Convert JSON List to Employer List
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public List<Employer> StringsToEmployers(List<string> rows)
        {
            List<Employer> _list = new List<Employer>();
            foreach (var row in rows)
            {
                _list.Add((Employer) JsonConvert.DeserializeObject<Employer>(row).Clone());
            }

            return _list;
        }
    }
}
