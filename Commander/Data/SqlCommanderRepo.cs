using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _repository;
        public SqlCommanderRepo(CommanderContext repository)
        {
            _repository = repository;
        }
        public IEnumerable<Command> GetAllCommad()
        {
            return _repository.commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _repository.commands.FirstOrDefault(c => c.Id == id);
        }
    }
}
