using System.Collections.Generic;
using videoProject.Model;
namespace videoProject.Data{

    public class MockCommanderRepo : ICommanderRepo{
        public IEnumerable<Command> GetAppCommands(){

            var commands = new List<Command>{
                new Command{Id=0,Name="Alex", Surname="Fadeev", PhoneNumber=23928323},
                new Command{Id=1,Name="Nikita", Surname="Deksnya", PhoneNumber=21312333},
                new Command{Id=2,Name="Vasya", Surname="Luckans", PhoneNumber=24354434},
                new Command{Id=3,Name="Genadiy", Surname="Borkov", PhoneNumber=22333232}
            };
            return commands;
            //throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id){
            return new Command{Id=0,Name="Alex", Surname="Fadeev", PhoneNumber=23928323};
            //throw new System.NotImplementedException();
        }
        
    }
}