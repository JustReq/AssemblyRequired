using AssemblyRequired.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssemblyRequired.Items.Placeable
{
	public class GantryHydraulicBaseItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gantry Hydraulic Base");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 32;
			item.maxStack = 2;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<GantryHydraulicBaseTile>();
		}
	}
}