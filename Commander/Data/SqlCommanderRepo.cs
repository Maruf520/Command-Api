﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommad()
        {
            return _context.commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.commands.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }
    }
}
