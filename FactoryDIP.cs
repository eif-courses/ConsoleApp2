using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class FactoryDIP
    {
        public static IQuest CreateQuestObject()
        {
            return new Quest(CreateLoggerObject(), CreateDatabaseObject());
        }

        public static IDatabase CreateDatabaseObject()
        {
            return new Firebase();
        }

        public static ILogger CreateLoggerObject()
        {
            return new SerilogLog();
        }
        public static IPlayer CreatePlayerObject(string name)
        {
            return new Player{ Name = name };
        }
    }
}
