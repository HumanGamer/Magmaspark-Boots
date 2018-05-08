using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagmasparkMod
{
    public class MagmasparkMod : Mod
    {
        internal static MagmasparkMod Instance;

        public MagmasparkMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
        }

        public override void Load()
        {
            Instance = this;

            //AddItem("Sparkwave Boots", new SparkwaveBootsItem());
        }

        public override void Unload()
        {

        }

        public override void PostSetupContent()
        {
            
        }

        public override void AddRecipeGroups()
        {
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LavaBucket, 5);
            recipe.AddIngredient(ItemID.Obsidian, 25);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.LavaCharm);
            recipe.AddRecipe();
        }
    }
}