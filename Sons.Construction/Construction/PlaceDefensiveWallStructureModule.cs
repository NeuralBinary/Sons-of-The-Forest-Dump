using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	[Serializable]
	public class PlaceDefensiveWallStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00006D94 File Offset: 0x00004F94
		[Token(Token = "0x170002A8")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00006DAC File Offset: 0x00004FAC
		[Token(Token = "0x170002A9")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0xE599D0", Offset = "0xE57FD0", VA = "0x180E599D0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceDefensiveWallStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x2E99690", Offset = "0x2E97C90", VA = "0x182E99690", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x2E99A40", Offset = "0x2E98040", VA = "0x182E99A40", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00006DDC File Offset: 0x00004FDC
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x2E9A1E0", Offset = "0x2E987E0", VA = "0x182E9A1E0")]
		private bool TryGetDefensiveWallSnapPointFromPilar(TargetInfo targetInfo, ModuleState moduleState, out Vector3 snapPos, out PilarStructure editingPilar, out Directions snapDir)
		{
			return default(bool);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00006DF4 File Offset: 0x00004FF4
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x2E9A6D0", Offset = "0x2E98CD0", VA = "0x182E9A6D0")]
		private bool TryGetDefensiveWallSnapPointFromDefensiveWall(TargetInfo targetInfo, ModuleState moduleState, out Vector3 snapPos, out Directions snapDir, out DefensiveWallStructure editingDw)
		{
			return default(bool);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00006E0C File Offset: 0x0000500C
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x2E9AEA0", Offset = "0x2E994A0", VA = "0x182E9AEA0")]
		private static bool Check90Snapping(ref Vector3 snapPos, ref Directions snapDir, float distanceBetweenElements)
		{
			return default(bool);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00006E24 File Offset: 0x00005024
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x2E9AF10", Offset = "0x2E99510", VA = "0x182E9AF10", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x2E9B880", Offset = "0x2E99E80", VA = "0x182E9B880", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x2E9BF20", Offset = "0x2E9A520", VA = "0x182E9BF20")]
		private void CreateNewPilar(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00006E3C File Offset: 0x0000503C
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x2E9C220", Offset = "0x2E9A820", VA = "0x182E9C220")]
		[CompilerGenerated]
		internal static bool <TryGetDefensiveWallSnapPointFromPilar>g__IsSupportingNonDw|8_0(ref PlaceDefensiveWallStructureModule.<>c__DisplayClass8_0 A_0)
		{
			return default(bool);
		}
	}
}
