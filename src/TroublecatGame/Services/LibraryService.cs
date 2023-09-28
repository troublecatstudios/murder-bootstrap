using System.Numerics;
using Bang;
using Bang.Entities;
using Murder;
using Murder.Assets;
using Murder.Components;
using Murder.Utilities;
using TroublecatGame.Assets;

namespace TroublecatGame.Services;

public static class LibraryService {
    public static LibraryAsset GetRoadLibrary()
    {
        return Game.Data.GetAsset<LibraryAsset>(CatGame.Profile.Library);
    }

    internal static Entity DropItem(World world, Vector2 position, Vector2 velocity, PrefabAsset prefab)
    {
        var spawned = prefab.CreateAndFetch(world);
        //spawned.SetIgnoreUntil(Game.Now + 0.75f);
        spawned.SetIgnoreTriggersUntil(Game.Now + 0.75f);
        spawned.SetGlobalTransform(new PositionComponent(position));
        spawned.SetVelocity(velocity);
        return spawned;
    }

    public static UiSkinAsset GetUiSkin()
    {
        return Game.Data.GetAsset<UiSkinAsset>(GetRoadLibrary().UiSkin);
    }
}
