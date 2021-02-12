using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommad()
        {
            var commad = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & pan"},
                new Command {Id = 1, HowTo = "CUt bread", Line = "Get a Knife", Platform = "Knife and chopping board"},
                new Command {Id = 2, HowTo = "Make Cup of tea", Line = "palce tea bag in cup", Platform = "Kettle & Cup"},
                new Command {Id = 3, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & pan"},
            };
            return commad;
        }

 
        public Command GetCommandById(int id)
        {
            /*            var command = new Command
                        {
                            Id = 0, HowTo = "sdgf", Line = "Boil water", Platform = "Kettle & pan"
                        };
                        return command;*/

           return  new Command { Id = 0, Line = "sdfs", HowTo = "sgsg", Platform = "dfgfdged" };
        }
    }
}
