using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;
namespace tk.tingyuxuan.utils
{
    public class MyCache
    {
        public string Path { set; get; }

        public void SetCache(object value)
        {
            BinaryFormatter bf = new BinaryFormatter();
            System.IO.StreamWriter swBinary = new System.IO.StreamWriter(Path);
            bf.Serialize(swBinary.BaseStream, value);
            swBinary.Close();
        }

        public object GetCache<T>()
        {
            object obj = null;
            BinaryFormatter bf = new BinaryFormatter();
            System.IO.StreamWriter swBinary = new System.IO.StreamWriter(Path);
            obj = bf.Deserialize(swBinary.BaseStream);
            swBinary.Close();
            return obj;
        }

    }
}
