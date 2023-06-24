using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public class CombineItemModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x2E28510", Offset = "0x2E26B10", VA = "0x182E28510")]
		public CombineItemModule(ModuleProfileDatabase targetProfileDB, ModuleProfileDatabase combinedProfileDB)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2E28550", Offset = "0x2E26B50", VA = "0x182E28550", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2E28DA0", Offset = "0x2E273A0", VA = "0x182E28DA0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
