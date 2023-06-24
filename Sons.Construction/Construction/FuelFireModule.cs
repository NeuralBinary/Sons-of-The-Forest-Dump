using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	public class FuelFireModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00009224 File Offset: 0x00007424
		[Token(Token = "0x17000378")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0000923C File Offset: 0x0000743C
		[Token(Token = "0x17000379")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00009254 File Offset: 0x00007454
		[Token(Token = "0x1700037A")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0000926C File Offset: 0x0000746C
		[Token(Token = "0x1700037B")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x2EF8740", Offset = "0x2EF6D40", VA = "0x182EF8740", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public FuelFireModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00009284 File Offset: 0x00007484
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x2EF8750", Offset = "0x2EF6D50", VA = "0x182EF8750", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x2EF8D10", Offset = "0x2EF7310", VA = "0x182EF8D10", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0000929C File Offset: 0x0000749C
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x2EF9060", Offset = "0x2EF7660", VA = "0x182EF9060")]
		private bool TryGetFuelTarget(TargetInfo targetInfo, ModuleProfile activeProfile, out Vector3 snapPos, out FireStructure targetFire)
		{
			return default(bool);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000092B4 File Offset: 0x000074B4
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x2EF9540", Offset = "0x2EF7B40", VA = "0x182EF9540", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x2EF9640", Offset = "0x2EF7C40", VA = "0x182EF9640", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
