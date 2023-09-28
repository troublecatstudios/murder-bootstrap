using Murder;
using Murder.Diagnostics;

namespace TroublecatGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                using Game game = new(new CatGame());
                game.Run();
            }
            catch (Exception ex) when (GameLogger.CaptureCrash(ex)) { }
        }
    }
}
