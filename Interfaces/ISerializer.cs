using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.WindowsForms
{
    public interface ISerializer
    {
        IEnumerable<T> Deserialize<T>(string fileName);
        void Serialize(string fileName, object item);
    }
}
