using Sprint0Copy.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0Copy.Commands
{
    internal class WalkingInPlaceCommand : ICommand
    {
        private ISprite sprite;
        public WalkingInPlaceCommand(ISprite sprite) 
        { 
            this.sprite = sprite;
        }

        public void Execute(Game1 game)
        {
            game.CurrentSprite = game.WalkingMario;
        }
    }
}
