using Murder;
using Murder.Assets;
using TroublecatGame.Assets;

namespace TroublecatGame;

public class CatGame : IMurderGame
{
    public static TroublecatProfile Profile => (TroublecatProfile)Game.Profile;

    public string Name => "TroublecatGame";

    public GameProfile CreateGameProfile() => new TroublecatProfile();
}
