using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Pattern
{
    public class MenuOptions
    {
        private readonly ICommand turnOnCommand;
        
        public MenuOptions(ICommand turnOnCommand)
        {
            this.turnOnCommand = turnOnCommand;
        }

        public void TurnOnButtonClick()
        {
            turnOnCommand.Execute();
        }

    } 
}
