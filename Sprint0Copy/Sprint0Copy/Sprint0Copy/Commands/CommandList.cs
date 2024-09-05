using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint0Copy.Commands
{
    internal class CommandList
    {
        Game1 game;
        public Dictionary<Keys, ICommand> KeyboardCommands { get; set ; }
        public Dictionary<Rectangle, ICommand> MouseCommands { get; set ; }
        public CommandList(Game1 game) 
        { 
            this.game = game;
            KeyboardCommands = new Dictionary<Keys, ICommand>();
            MouseCommands = new Dictionary<Rectangle, ICommand>();
            BuildCommands();
        }
        
        public void BuildCommands()
        {
            KeyboardCommands.Add(Keys.D0, new QuitCommand(game));
            KeyboardCommands.Add(Keys.D1, new StandInPlaceCommand(game.IdleMario));
            KeyboardCommands.Add(Keys.D2, new WalkingInPlaceCommand(game.WalkingMario));
            KeyboardCommands.Add(Keys.D3, new FloatingCommand(game.FloatingMario));
            KeyboardCommands.Add(Keys.D4, new RunningCommand(game.RunningMario));

            MouseCommands.Add(new Rectangle(0, 0, 400, 200), new StandInPlaceCommand(game.IdleMario));
            MouseCommands.Add(new Rectangle(400, 0, 400, 200), new WalkingInPlaceCommand(game.WalkingMario));
            MouseCommands.Add(new Rectangle(0, 200, 400, 200), new FloatingCommand(game.FloatingMario));
            MouseCommands.Add(new Rectangle(400, 200, 400, 200), new RunningCommand(game.RunningMario));
        }
    }
}
