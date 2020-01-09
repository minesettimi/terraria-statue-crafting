using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;

namespace StatueCrafting.Items
{
    public class StatueSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Statue Soul");
            Tooltip.SetDefault("A soul that can create a creature based on its vessel");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
        }

        public override void SetDefaults()
        {
            item.width = 11;
            item.height = 11;
            item.maxStack = 99;
            item.value = 1000000;
            item.rare = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BatStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BloodZombieStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BoneSkeletonStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.ChestStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.CrabStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.DripplerStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.GraniteGolemStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.HarpyStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.HopliteStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.JellyfishStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MedusaStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.PigronStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.PiranhaStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SharkStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SkeletonStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.SlimeStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.UndeadVikingStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.UnicornStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.WallCreeperStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.WraithStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.KingStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.QueenStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddIngredient(ItemID.Bomb, 198);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BombStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddIngredient(ItemID.LifeCrystal, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.HeartStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddIngredient(ItemID.ManaCrystal, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.StarStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(mod.ItemType("StatueSoul"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MushroomStatue);
            recipe.AddRecipe();
            ///////////////////////////////////////////////////////////////////
        }
    }
}