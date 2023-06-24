using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	public class PlaceStackStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00009C14 File Offset: 0x00007E14
		[Token(Token = "0x170003BE")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6001017")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00009C2C File Offset: 0x00007E2C
		[Token(Token = "0x170003BF")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6001018")]
			[Address(RVA = "0x2F0A3F0", Offset = "0x2F089F0", VA = "0x182F0A3F0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceStackStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00009C44 File Offset: 0x00007E44
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x2F0AA30", Offset = "0x2F09030", VA = "0x182F0AA30", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00009C5C File Offset: 0x00007E5C
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x2F0AB80", Offset = "0x2F09180", VA = "0x182F0AB80")]
		private bool TryGetSnapPointFromStack(TargetInfo targetInfo, out StackStructure editingStack, out Vector3 snapPos)
		{
			return default(bool);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x2F0ADB0", Offset = "0x2F093B0", VA = "0x182F0ADB0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00009C74 File Offset: 0x00007E74
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x2F0AF90", Offset = "0x2F09590", VA = "0x182F0AF90", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600101E")]
		[Address(RVA = "0x2F0B0C0", Offset = "0x2F096C0", VA = "0x182F0B0C0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
