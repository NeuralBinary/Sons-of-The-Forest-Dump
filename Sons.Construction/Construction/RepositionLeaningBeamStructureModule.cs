using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class RepositionLeaningBeamStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000063A4 File Offset: 0x000045A4
		[Token(Token = "0x1700027B")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x2E7F840", Offset = "0x2E7DE40", VA = "0x182E7F840")]
		public RepositionLeaningBeamStructureModule(ModuleProfileDatabase supportPilarDb, ModuleProfileDatabase liftPilarDb, ModuleProfileDatabase levelingPilarDb)
		{
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x2E7F9D0", Offset = "0x2E7DFD0", VA = "0x182E7F9D0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000063BC File Offset: 0x000045BC
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x2E801E0", Offset = "0x2E7E7E0", VA = "0x182E801E0", Slot = "59")]
		protected override bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000063D4 File Offset: 0x000045D4
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1EAE560", Offset = "0x1EACB60", VA = "0x181EAE560", Slot = "63")]
		protected override InputModes GetActivationInputMode(ModuleState state)
		{
			return InputModes.AlwaysTwoSteps;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x2E802E0", Offset = "0x2E7E8E0", VA = "0x182E802E0", Slot = "68")]
		public override void Activated(ModuleState state)
		{
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000063EC File Offset: 0x000045EC
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x2E80420", Offset = "0x2E7EA20", VA = "0x182E80420", Slot = "54")]
		public override bool TryValidateProfile(ItemData targetItem, int placementMode, TargetInfo targetInfo, ref ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x2E80530", Offset = "0x2E7EB30", VA = "0x182E80530", Slot = "69")]
		public override void Deactivated(ModuleState state)
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00006404 File Offset: 0x00004604
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x2E805C0", Offset = "0x2E7EBC0", VA = "0x182E805C0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x2E80840", Offset = "0x2E7EE40", VA = "0x182E80840", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x2E80AC0", Offset = "0x2E7F0C0", VA = "0x182E80AC0")]
		private static void GetRepoMode(TargetInfo targetInfo, int placementMode, out bool level, out bool lift, out bool support)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x2E80B40", Offset = "0x2E7F140", VA = "0x182E80B40")]
		private void SetupPilarFromLeaningBeam(TargetInfo targetInfo, ModuleProfile profile, bool leveled)
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0000641C File Offset: 0x0000461C
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x2E81DE0", Offset = "0x2E803E0", VA = "0x182E81DE0")]
		private bool TryGetSimpleLiftProfile(ModuleProfile fromProfile, out ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00006434 File Offset: 0x00004634
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x2E81E10", Offset = "0x2E80410", VA = "0x182E81E10")]
		private bool TryGetLevelingProfile(ModuleProfile fromProfile, out ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0000644C File Offset: 0x0000464C
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x2E81E40", Offset = "0x2E80440", VA = "0x182E81E40", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00006464 File Offset: 0x00004664
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x2E81E60", Offset = "0x2E80460", VA = "0x182E81E60")]
		private bool TryGetPredictedForwardStructureSnapPointFromLeaningBeam(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0000647C File Offset: 0x0000467C
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x2E82760", Offset = "0x2E80D60", VA = "0x182E82760")]
		private static bool CheckProfileMatchesSupportHeight(Vector3 snapPos, ModuleProfile moduleProfile, BeamStructure beamStructure, ref float supportHeight)
		{
			return default(bool);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x2E82940", Offset = "0x2E80F40", VA = "0x182E82940")]
		private ModuleProfileDatabase GetProfileDatabase(bool level, bool support)
		{
			return null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00006494 File Offset: 0x00004694
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x2E82960", Offset = "0x2E80F60", VA = "0x182E82960")]
		private Vector3 GetCustomTargetPos(TargetInfo targetInfo)
		{
			return default(Vector3);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x2E82BF0", Offset = "0x2E811F0", VA = "0x182E82BF0")]
		[CompilerGenerated]
		internal static void <SetupPilarFromLeaningBeam>g__TransferLinkedBeam|15_0(BeamStructure from, Structure to, BeamDirections dirFrom, Directions dirTo, ref RepositionLeaningBeamStructureModule.<>c__DisplayClass15_0 A_4)
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000064AC File Offset: 0x000046AC
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x2E82DB0", Offset = "0x2E813B0", VA = "0x182E82DB0")]
		[CompilerGenerated]
		internal static bool <SetupPilarFromLeaningBeam>g__CheckAutoLeveling|15_1(TargetInfo targetInfo, BeamStructure beamStructure, float groundHeight, ModuleProfileDatabase db, ref StructureElement pilarElement, out float leveledHeight, out ModuleProfile leveledProfile)
		{
			return default(bool);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x2E83440", Offset = "0x2E81A40", VA = "0x182E83440")]
		[CompilerGenerated]
		internal static void <SetupPilarFromLeaningBeam>g__SpawnAsDynamicPickup|15_2(Vector3 pos, StructureElement elementPrefab, float torqueMultiplier)
		{
		}

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x68")]
		private ModuleProfileDatabase _supportPilarDatabase;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0x70")]
		private ModuleProfileDatabase _liftPilarDatabase;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0x78")]
		private ModuleProfileDatabase _levelingPilarDatabase;
	}
}
