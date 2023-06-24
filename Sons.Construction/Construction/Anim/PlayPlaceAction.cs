using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	public class PlayPlaceAction : IBeginPlaceActionReceiver
	{
		// Token: 0x06001662 RID: 5730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public PlayPlaceAction(ConstructionManager manager)
		{
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x2E0A240", Offset = "0x2E08840", VA = "0x182E0A240", Slot = "4")]
		public void BeginPlaceAction(TargetInfo targetInfo, IConstructionModule module, StructureElement elementPrefab, int placementMode)
		{
		}

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x10")]
		private readonly ConstructionManager _manager;
	}
}
