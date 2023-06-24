using System;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public class PlaceBeamOnTreeModule : ConstructionModule, INonStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule, ISnapPointPredictingModule
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0000617C File Offset: 0x0000437C
		[Token(Token = "0x17000275")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x22F5170", Offset = "0x22F3770", VA = "0x1822F5170", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00006194 File Offset: 0x00004394
		[Token(Token = "0x17000276")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2E75D50", Offset = "0x2E74350", VA = "0x182E75D50")]
		public PlaceBeamOnTreeModule(ModuleProfileDatabase leaningBeamDb, ModuleProfileDatabase treeStructureDb, ModuleProfileDatabase treePlatformBeamProfileDB, ModuleProfileDatabase groundedFakePilarDb, ModuleProfileDatabase waterBorneFakePilarDb)
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000061AC File Offset: 0x000043AC
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x2E75EF0", Offset = "0x2E744F0", VA = "0x182E75EF0", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000061C4 File Offset: 0x000043C4
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x2E76170", Offset = "0x2E74770", VA = "0x182E76170")]
		private bool TryFindSnapPointFromTree(TargetInfo targetInfo, StructureElement beamPrefab, out Vector3 snapPos, out Vector3 placeAxis, out TreeStructure support, out Directions supportDir, out bool isInvalid, out WorldObjectLocatorHolder locatorHolder)
		{
			return default(bool);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x2E76E60", Offset = "0x2E75460", VA = "0x182E76E60", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000061DC File Offset: 0x000043DC
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x2E77640", Offset = "0x2E75C40", VA = "0x182E77640", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x2E77C00", Offset = "0x2E76200", VA = "0x182E77C00", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x2E78330", Offset = "0x2E76930", VA = "0x182E78330")]
		private void SetupTreeStructureFromTree(TargetInfo targetInfo)
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x2E784F0", Offset = "0x2E76AF0", VA = "0x182E784F0")]
		private void SetupBeamFromTreeStructure(TargetInfo targetInfo)
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x2E78690", Offset = "0x2E76C90", VA = "0x182E78690")]
		private void SetupCrossBeamsFromTreeBeams(TargetInfo targetInfo)
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000061F4 File Offset: 0x000043F4
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x2E78E40", Offset = "0x2E77440", VA = "0x182E78E40", Slot = "78")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0000620C File Offset: 0x0000440C
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x2E78E60", Offset = "0x2E77460", VA = "0x182E78E60")]
		private bool TryGetBeamPredictedSnapPointFromTreeStructure(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x68")]
		private readonly ModuleProfileDatabase _treeStructureDB;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x70")]
		private readonly ModuleProfileDatabase _treePlatformBeamProfileDB;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x78")]
		private readonly ModuleProfileDatabase _groundedFakePilarProfileDatabase;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x80")]
		private readonly ModuleProfileDatabase _waterBorneFakePilarProfileDatabase;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] BeamDirs;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] NextSiblingDirs;
	}
}
