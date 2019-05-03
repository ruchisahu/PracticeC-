using System;

namespace dependencyInjection1
{
    internal class DataAccess
    {
        internal void LoadData()
        {
            Console.WriteLine(" loading data");
        }

        internal void SaveData(string v)
        {
            Console.WriteLine("saving data {v}");
        }
    }
}