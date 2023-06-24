using System;
using System.Runtime.CompilerServices;
using Construction.Anim;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	public class PlayerStateChecker : IIdleStateUpdateReceiver
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C4")]
		private ConstructionManager.PlayerInfo PlayerInfo
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170001C5")]
		private PlayerBuildingModeAction BuildingModeAction
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public PlayerStateChecker(ConstructionManager.PlayerInfo playerInfo, PlayerBuildingModeAction buildingModeAction)
		{
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2E1EBF0", Offset = "0x2E1D1F0", VA = "0x182E1EBF0", Slot = "4")]
		public void IdleStateUpdate(out ExitStatus exitStatus)
		{
		}
	}
}
