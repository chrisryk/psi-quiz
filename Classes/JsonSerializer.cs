using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Quiz.WindowsForms
{
    internal class JsonSerializer : ISerializer
    {
        public IEnumerable<T> Deserialize<T>(string fileName)
        {
            StreamReader stream = new StreamReader(fileName);
            string content = stream.ReadToEnd();
            var result = JsonConvert.DeserializeObject<IEnumerable<T>>(content);
            stream.Close();
            return result;
        }

        public void Serialize(string fileName, object item)
        {
            Regex pattern = new Regex("]$");

            StreamReader streamRead = new StreamReader(fileName);
            string content = streamRead.ReadToEnd();
            streamRead.Close();

            if (!string.IsNullOrEmpty(content))
            {
                content = pattern.Replace(content, ",\n");
            }
            else
            {
                content += "[\n";
            }


            StreamWriter streamWrite = new StreamWriter(fileName, false);
            //false - results overwrite text
            
            //StreamWriter streamWrite = new StreamWriter(fileName, true);
            // true - results append text

            content += JsonConvert.SerializeObject(item, Formatting.Indented) + "\n]";
            streamWrite.Write(content);
            streamWrite.Close();
        }
    }
}
