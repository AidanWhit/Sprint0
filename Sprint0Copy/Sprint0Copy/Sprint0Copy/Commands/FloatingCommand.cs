using Sprint0Copy.Sprites;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0Copy.Commands
{
    internal class FloatingCommand : ICommand
    {
        private ISprite sprite;
        public FloatingCommand(ISprite sprite) 
        {
            this.sprite = sprite;
        }

        public void Execute(Game1 game)
        {
             game.CurrentSprite = game.FloatingMario;
        }
    }
}
