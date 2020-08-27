using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using videoProject.Data;
using videoProject.Model;

namespace videoProject.Controllers{
       
        [Route("Api/commands")]
        [ApiController]
    public class CommandsController : ControllerBase{
        private ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
          _repository = repository;  
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET RESPONSE api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands(){
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }
        //GET REQUEST api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id){
            
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}