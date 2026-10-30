global using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using MelonLoader;
using Soulthorn;

[assembly: MelonInfo(typeof(Soulthorn.SoulthornOnStart), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6-Epic")]

namespace Soulthorn;

public class SoulthornOnStart : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<SoulthornOnStart>("Soulthorn loaded!");
    }
}