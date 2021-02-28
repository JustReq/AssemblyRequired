using AssemblyRequired.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace AssemblyRequired.Items.Placeable
{
	public class GantryHydraulicArmItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gantry Hydraulic Arm");
		}

		public override void SetDefaults()
		{
			item.width = 48;
			item.height = 46;
			item.maxStack = 2;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<GantryHydraulicArmTile>();
		}
	}
}