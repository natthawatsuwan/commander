using System.Collections;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        //public IEnumerable<Command> GetAppCommands()
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);

    }
}