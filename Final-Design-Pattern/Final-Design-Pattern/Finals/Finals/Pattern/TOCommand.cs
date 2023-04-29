using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Pattern
{
    internal class TOCommand : ICommand
    {
        private Buttons btnon;

        public TOCommand(Buttons btnon)
        {
            this.btnon = btnon;
        }

        public void Execute()
        {
            btnon.TurnOn();
        }
    }
}
