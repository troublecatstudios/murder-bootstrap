using System.Numerics;
using Murder.Assets;
using Murder.Assets.Graphics;
using Murder.Attributes;
using Murder.Core.Graphics;

namespace TroublecatGame.Assets;

public class UiSkinAsset : GameAsset {
    public override string EditorFolder => "#Ui";

    public override char Icon => '';

    public override Vector4 EditorColor => new Vector4(1f, .8f, .25f, 1f);

    [GameAssetId<SpriteAsset>]
    public Guid Logo = Guid.Empty;

    public Color MainMenuBg = Color.FromHex("4c6885");

    public Color MainMenuItemShadow = Color.FromHex("000000");

    public Color MainMenuItem = Color.FromHex("f6afb1");

    public Color MainMenuItemSelected = Color.FromHex("952857");
}
