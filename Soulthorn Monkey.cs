using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulthornMod
{
    internal class Soulthorn : ModTower
    {
        public override TowerSet TowerSet =>   TowerSet.Magic;

        public override string BaseTower => TowerType.CorvusSpiritTower;

        public override int Cost => 750;

        public override int TopPathUpgrades => 0;

        public override int MiddlePathUpgrades => 0;

        public override int BottomPathUpgrades => 0;

        public override string Description => "A mischievous spirit bonded to ancient thorn crystals. Within them slumber five constructs of power, each waiting to awaken.";

        public override string DisplayName => "Soulthorn";
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
         
        }
    }
}
