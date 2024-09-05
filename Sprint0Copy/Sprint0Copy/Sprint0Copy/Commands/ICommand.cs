using Sprint0Copy.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0Copy.Commands
{
    public interface ICommand
    {
        void Execute(Game1 game);
    }
}
