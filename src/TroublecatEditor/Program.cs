using Murder.Editor;

namespace TroublecatEditor
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var editor = new Architect(new TroublecatArchitect()))
            {
                editor.Run();
            }
        }
    }
}
