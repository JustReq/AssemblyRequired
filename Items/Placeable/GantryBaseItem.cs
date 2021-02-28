using AssemblyRequired.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssemblyRequired.Items.Placeable
{
	public class GantryBaseItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gantry Base");
		}

		public override void SetDefaults()
		{
			item.width = 48;
			item.height = 16;
			item.maxStack = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<GantryBaseTile>();
		}
	}
}