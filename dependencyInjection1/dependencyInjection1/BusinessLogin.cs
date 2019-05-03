using System;

namespace dependencyInjection1
{
    internal class BusinessLogin
    {
        internal void PrecessData()
        {
            Logger logger = new Logger();
            DataAccess dataaccess = new DataAccess();
            logger.Log("stating processing of data");
            Console.WriteLine("Processing the data");
            dataaccess.LoadData();
            dataaccess.SaveData("ProcessingInfo");
            logger.Log("finished processing");
        }
    }
}