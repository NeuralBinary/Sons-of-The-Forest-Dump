using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public class PlaceBridgeRopeStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0000686C File Offset: 0x00004A6C
		[Token(Token = "0x1700028D")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00006884 File Offset: 0x00004A84
		[Token(Token = "0x1700028E")]
		public override bool AllowsMovementWhenActivated
		{
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0000689C File Offset: 0x00004A9C
		[Token(Token = "0x1700028F")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x2E87740", Offset = "0x2E85D40", VA = "0x182E87740", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceBridgeRopeStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000068B4 File Offset: 0x00004AB4
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x2E8BC70", Offset = "0x2E8A270", VA = "0x182E8BC70", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x2E8C1B0", Offset = "0x2E8A7B0", VA = "0x182E8C1B0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x2E8C290", Offset = "0x2E8A890", VA = "0x182E8C290", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000068CC File Offset: 0x00004ACC
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x2E8CDA0", Offset = "0x2E8B3A0", VA = "0x182E8CDA0")]
		private bool TryGetBridgeRopeSnapPointFromSupport(TargetInfo targetInfo, out Vector3 snapPos, out Vector3 snapAxis, out Directions snapDir, out IBridgeRopeSupport support, out BridgeRopeStructure editingBridgeRope)
		{
			return default(bool);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000068E4 File Offset: 0x00004AE4
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x2E8D250", Offset = "0x2E8B850", VA = "0x182E8D250")]
		private bool TryGetBridgeRopeSnapPointFromBridgeRope(TargetInfo targetInfo, out Vector3 snapPos, out BridgeRopeStructure editingBridgeRope)
		{
			return default(bool);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000068FC File Offset: 0x00004AFC
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x2E8D3F0", Offset = "0x2E8B9F0", VA = "0x182E8D3F0", Slot = "59")]
		protected override bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x2E8D5D0", Offset = "0x2E8BBD0", VA = "0x182E8D5D0", Slot = "68")]
		public override void Activated(ModuleState state)
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x2E8D780", Offset = "0x2E8BD80", VA = "0x182E8D780", Slot = "69")]
		public override void Deactivated(ModuleState state)
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00006914 File Offset: 0x00004B14
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x2E8D900", Offset = "0x2E8BF00", VA = "0x182E8D900", Slot = "66")]
		public override bool TrySecondStepActivation(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x2E8DAE0", Offset = "0x2E8C0E0", VA = "0x182E8DAE0")]
		private void TryLookupSecondSupport(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0000692C File Offset: 0x00004B2C
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x2E8E270", Offset = "0x2E8C870", VA = "0x182E8E270", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x2E8E660", Offset = "0x2E8CC60", VA = "0x182E8E660", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x2E8E860", Offset = "0x2E8CE60", VA = "0x182E8E860")]
		private void CreateNewBridgeRope(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x2E8ED30", Offset = "0x2E8D330", VA = "0x182E8ED30")]
		[CompilerGenerated]
		internal static void <TryLookupSecondSupport>g__LookupSecondSupport|16_0(out IBridgeRopeSupport support2, out Directions support2Dir, ref PlaceBridgeRopeStructureModule.<>c__DisplayClass16_0 A_2)
		{
		}
	}
}
