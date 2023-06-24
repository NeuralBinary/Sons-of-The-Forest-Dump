using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public class CombineItemIntoRaftModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00009824 File Offset: 0x00007A24
		[Token(Token = "0x170003A6")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x2F02D70", Offset = "0x2F01370", VA = "0x182F02D70")]
		public CombineItemIntoRaftModule(ModuleProfileDatabase targetProfileDB, ModuleProfileDatabase combinedProfileDB)
		{
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0000983C File Offset: 0x00007A3C
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x2F02E10", Offset = "0x2F01410", VA = "0x182F02E10", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x2F03510", Offset = "0x2F01B10", VA = "0x182F03510", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
