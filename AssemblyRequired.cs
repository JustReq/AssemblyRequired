using Terraria.ModLoader;

namespace AssemblyRequired
{
	public class AssemblyRequired : Mod
	{
		public static ModHotKey CutsceneHotkey;

		internal static AssemblyRequired Instance;

		public override void Load()
		{
			CutsceneHotkey = RegisterHotKey("Iron Man Cutscene", "Z");

			Instance = this;

			AddEquipTexture(null, EquipType.Legs, "IronManMk2_Legs", "AssemblyRequired/IronManSuits/Mark2/IronManMk2_Legs");
			AddEquipTexture(new IronManSuits.Mark2.IronManMk2Head(), null, EquipType.Head, "IronManMk2Head", "AssemblyRequired/IronManSuits/Mark2/IronManMk2_Head");
			AddEquipTexture(new IronManSuits.Mark2.IronManMk2Body(), null, EquipType.Body, "IronManMk2Body", "AssemblyRequired/IronManSuits/Mark2/IronManMk2_Body", "AssemblyRequired/IronManSuits/Mark2/IronManMk2_Arms");
			AddEquipTexture(new IronManSuits.Mark2.IronManMk2Legs(), null, EquipType.Legs, "IronManMk2Legs", "AssemblyRequired/IronManSuits/Mark2/IronManMk2_Legs");
		}
	}
}