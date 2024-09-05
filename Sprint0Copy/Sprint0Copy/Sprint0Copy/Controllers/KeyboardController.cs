using Microsoft.Xna.Framework.Input;
using Sprint0Copy.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


namespace Sprint0Copy.Controllers
{
    internal class KeyboardController : IController
    {
        private ICommand currentCommand;
        private KeyboardState oldState;
        private Dictionary<Keys, ICommand> dict;
        private CommandList commandList;

        private Keys[] keyArray = {Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4};
        public KeyboardController(Game1 game)
        {
            commandList = new CommandList(game);
            dict = commandList.KeyboardCommands;
            currentCommand = game.CurrentCommand;
        }
        public void Update(Game1 game)
        {
            currentCommand = game.CurrentCommand;
            
            foreach (Keys key in dict.Keys)
            {
                if (Keyboard.GetState().IsKeyDown(key))
                {
                    dict.TryGetValue(key, out ICommand command);
                    //New Command has been found
                    if (command != currentCommand)
                    {
                        currentCommand = command;
                        break;
                    }
                }
            }

            game.CurrentCommand = currentCommand;
            currentCommand.Execute(game);
        }
    }
}
