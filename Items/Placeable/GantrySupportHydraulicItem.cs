using AssemblyRequired.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssemblyRequired.Items.Placeable
{
	public class GantrySupportHydraulicItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gantry Support Hydraulic");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 64;
			item.maxStack = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<GantrySupportHydraulicTile>();
		}
	}
}