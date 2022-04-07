using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Quiz.WindowsForms
{
    internal class JsonSerializer : ISerializer
    {
        public IEnumerable<T> Deserialize<T>(string fileName)
        {
            using (StreamReader stream = new StreamReader(fileName))
            {
                string content = stream.ReadToEnd();
                var result = JsonConvert.DeserializeObject<IEnumerable<T>>(content);
                return result;
            }
        }

        public void Serialize(string fileName, object item)
        {
            Regex pattern = new Regex("]$");
            string content;

            using (StreamReader streamRead = new StreamReader(fileName))
            {
                content = streamRead.ReadToEnd();
            }

            if (!string.IsNullOrEmpty(content))
            {
                content = pattern.Replace(content, ",\n");
            }
            else
            {
                content += "[\n";
            }

            // true - results append text
            //StreamWriter streamWrite = new StreamWriter(fileName, true);
            
            //false - results overwrite text
            using (StreamWriter streamWrite = new StreamWriter(fileName, false))
            {
                content += JsonConvert.SerializeObject(item, Formatting.Indented) + "\n]";
                streamWrite.Write(content);
            }
        }
    }
}
