using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public class PlaceLeaningBeamStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0000629C File Offset: 0x0000449C
		[Token(Token = "0x17000279")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x000062B4 File Offset: 0x000044B4
		[Token(Token = "0x1700027A")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x22F5170", Offset = "0x22F3770", VA = "0x1822F5170", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x2E7A630", Offset = "0x2E78C30", VA = "0x182E7A630")]
		public PlaceLeaningBeamStructureModule(ModuleProfileDatabase leaningBeamDb, ModuleProfileDatabase groundedFakePilarDb, ModuleProfileDatabase waterBorneFakePilarDb)
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x2E7A890", Offset = "0x2E78E90", VA = "0x182E7A890", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x2E7ABF0", Offset = "0x2E791F0", VA = "0x182E7ABF0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000062CC File Offset: 0x000044CC
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x2E7B480", Offset = "0x2E79A80", VA = "0x182E7B480", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x2E7C340", Offset = "0x2E7A940", VA = "0x182E7C340", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x2E7C810", Offset = "0x2E7AE10", VA = "0x182E7C810")]
		private IBeamSupport CheckForwardSupportLastMinuteStitching(TargetInfo targetInfo, ModuleProfile beamProfile)
		{
			return null;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x2E7CA00", Offset = "0x2E7B000", VA = "0x182E7CA00")]
		private static void CheckSupportsCompatibility(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x2E7CE30", Offset = "0x2E7B430", VA = "0x182E7CE30")]
		private static void CalcBeamPlaceAxisFromBackSupport(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x2E7CF60", Offset = "0x2E7B560", VA = "0x182E7CF60")]
		private void SetupBeamFromBeamSupport(TargetInfo targetInfo, bool rockStructure)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x2E7D150", Offset = "0x2E7B750", VA = "0x182E7D150")]
		private void SetupBeamFromSupports(TargetInfo targetInfo, bool rockStructure)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x2E7D470", Offset = "0x2E7BA70", VA = "0x182E7D470")]
		private void ProcessBeamWallLinking(TargetInfo targetInfo)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x2E7D7E0", Offset = "0x2E7BDE0", VA = "0x182E7D7E0")]
		public static void Log(string message)
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000062E4 File Offset: 0x000044E4
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x2E7D850", Offset = "0x2E7BE50", VA = "0x182E7D850", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000062FC File Offset: 0x000044FC
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2E7D960", Offset = "0x2E7BF60", VA = "0x182E7D960")]
		private bool TryGetPredictedBeamSnapPointFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00006314 File Offset: 0x00004514
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2E7E060", Offset = "0x2E7C660", VA = "0x182E7E060")]
		private bool TryGetPredictedBeamSnapPointFromGroundedBeamFakePilars(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000632C File Offset: 0x0000452C
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2E7E490", Offset = "0x2E7CA90", VA = "0x182E7E490")]
		private Vector3 GetCustomTargetPos(TargetInfo targetInfo, ModuleProfile profile)
		{
			return default(Vector3);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00006344 File Offset: 0x00004544
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2E7E850", Offset = "0x2E7CE50", VA = "0x182E7E850")]
		private Vector3 GetApexCustomTargetPos(TargetInfo targetInfo)
		{
			return default(Vector3);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000635C File Offset: 0x0000455C
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2E7EA00", Offset = "0x2E7D000", VA = "0x182E7EA00")]
		private Vector3 GetCircleTargetPos(TargetInfo targetInfo, ModuleProfile profile)
		{
			return default(Vector3);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00006374 File Offset: 0x00004574
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2E7EAC0", Offset = "0x2E7D0C0", VA = "0x182E7EAC0")]
		private static bool IsLeaningAgainstApex(IBeamSupport targetBeamSupport, Directions targetDir)
		{
			return default(bool);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0000638C File Offset: 0x0000458C
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2E7EB50", Offset = "0x2E7D150", VA = "0x182E7EB50")]
		[CompilerGenerated]
		internal static Vector3 <ShowStagedPreview>g__Get2SideSupportedArrowAxis|8_0(ref PlaceLeaningBeamStructureModule.<>c__DisplayClass8_0 A_0)
		{
			return default(Vector3);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2E7EE60", Offset = "0x2E7D460", VA = "0x182E7EE60")]
		[CompilerGenerated]
		internal static List<WallStructure> <ProcessBeamWallLinking>g__GetRightBellowWall|16_0(BeamStructure beam)
		{
			return null;
		}

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x68")]
		private readonly ModuleProfileDatabase _groundedFakePilarProfileDatabase;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x70")]
		private readonly ModuleProfileDatabase _waterBorneFakePilarProfileDatabase;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;
	}
}
