using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    [Serializable]
    public class Data
    {
        private object[] database = new object[400000];
        public Data()
        {
            Console.WriteLine("entered main constructor");
            load();
        }
        public Data(object[] newDatabase)
        {
            Console.WriteLine("entered secondary constructor");
            int length = database.Length;
            for (int i = 0; i < length; i++)
            {
                database[i] = null;
            }
            database[0] = "first item";
        }
        public bool add(object obj)
        {
            int length = database.Length;
            for(int i = 0; i < length; i++)
            {
                if(database[i] == null)
                {
                    database[i] = obj;
                    //Console.WriteLine(database[i].ToString());
                    //Console.ReadLine();
                    return true;
                }
            }
            return false;
        }
        public object show()
        {
            return database;
        }
        public void save(Data saveFile)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("database" + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, saveFile);
            stream.Close();
        }
        public object[] getData()
        {
            return database;
        }
        public void load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("database" + ".bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Data newData = (Data)formatter.Deserialize(stream);
            stream.Close();
            database = newData.getData();
            //Console.WriteLine(newData.getData());
            //Console.ReadLine();
        }
    }
}
