using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagmasparkMod.Items
{
    [AutoloadEquip(EquipType.Shoes)]
    public class MagmasparkBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magmaspark Boots");
            Tooltip.SetDefault("Allows flight, super fast running, and extra mobility on ice"
                             + "\n7 % increased movement speed"
                             + "\nProvides the ability to walk on water and lava"
                             + "\nGrants immunity to fire blocks and 7 seconds of immunity to lava");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 17);
            item.rare = ItemRarityID.Lime;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // Lava Waders
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaMax += 420;

            // Frostspark Boots
            player.accRunSpeed = 6.75f;
            player.rocketBoots = 3;
            player.moveSpeed += 0.08f;
            player.iceSkate = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
