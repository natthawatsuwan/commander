using System.Collections.Generic;
using Commander.Models;
//using UnityEngine.Rendering.PostProcessing;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {

            var commands = new List<Command>
            {
               new Command{Id=0, Howto = "Bioi egg", Line = "Boi awter", Platform = "Ketle n pan" },
               new Command{Id=1, Howto = "bue bread", Line = "Knife", Platform = "Knife n choppoern" },
               new Command{Id=2, Howto = "make cup of tea", Line = "cop", Platform = "love it" }
            };
            return commands;
        }
            public Command GetCommandById(int Id)
            {
                return new Command{Id=0, Howto = "Bioi egg", Line = "Boi awter", Platform = "Ketle n pan" };
            }
        

    }
}