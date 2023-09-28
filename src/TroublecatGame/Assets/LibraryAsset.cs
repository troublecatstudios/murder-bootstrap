using System.Numerics;
using Murder.Assets;
using Murder.Attributes;
using Murder.Utilities;

namespace TroublecatGame.Assets;

public class LibraryAsset : GameAsset {
    public override string EditorFolder => "#\uf02dLibraries";

    public override char Icon => '\uf02d';

    public override Vector4 EditorColor => "#FA5276".ToVector4Color();

    [GameAssetId<UiSkinAsset>]
    public readonly Guid UiSkin = Guid.Empty;
}
