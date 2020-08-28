using System.Collections.Generic;
using videoProject.Model;

namespace videoProject.Data{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}