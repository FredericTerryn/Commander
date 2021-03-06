using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
             new Command{Id=0, HowTo="Boil an egg", Line="boil water", Platform="kettle & pan"},
             new Command{Id=0, HowTo="Cut Bread", Line="get knife", Platform="kettle & pan"},
             new Command{Id=0, HowTo="Make cup of tea", Line="place teabag in cup", Platform="kettle & pan"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="boil water", Platform="kettle & pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}