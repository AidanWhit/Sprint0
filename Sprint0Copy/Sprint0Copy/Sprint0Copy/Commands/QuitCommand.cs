using Microsoft.Xna.Framework;
using Sprint0Copy.Sprites;


namespace Sprint0Copy.Commands
{
    
    internal class QuitCommand : ICommand
    {
        private Game game;

        public QuitCommand(Game game)
        {
            this.game = game;
        }

        public void Execute(Game1 game)
        {
            this.game.Exit();
        }

    }
}
