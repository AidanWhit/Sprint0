using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint0Copy.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0Copy.Controllers
{
    internal class MouseController : IController
    {
        private MouseState mouse;
        private MouseState currentState;


        private Dictionary<Rectangle, ICommand> mouseCommands;
        private ICommand currentCommand, command;

        private QuitCommand quitCommand;

        private CommandList commandList;

        public MouseController(Game1 game, QuitCommand quitCommand)
        {

            commandList = new CommandList(game);
            currentCommand = game.CurrentCommand;
            this.quitCommand = quitCommand;
            mouseCommands = commandList.MouseCommands;
            currentState = Mouse.GetState();

        }

        public void Update(Game1 game)
        {
            currentCommand = game.CurrentCommand;
            mouse = Mouse.GetState();
            if (currentState.LeftButton != mouse.LeftButton)
            {
                foreach (Rectangle rect in mouseCommands.Keys)
                {
                    if (rect.Contains(mouse.Position))
                    {
                        mouseCommands.TryGetValue(rect, out command);
                        if (currentCommand != command)
                        {
                            currentCommand = command;
                            break;
                        }
                    }
                }
            }

            else if(currentState.RightButton != mouse.RightButton)
            {
                currentCommand = quitCommand;
            }
            game.CurrentCommand = currentCommand;
            currentCommand.Execute(game);

        }
    }
}
