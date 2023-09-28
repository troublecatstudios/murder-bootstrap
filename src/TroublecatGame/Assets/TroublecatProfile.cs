using Murder.Assets;
using Murder.Attributes;

namespace TroublecatGame.Assets;

public class TroublecatProfile : GameProfile {
    [GameAssetId(typeof(LibraryAsset))]
    public readonly Guid Library;
}
