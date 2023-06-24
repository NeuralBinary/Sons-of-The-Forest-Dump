using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	[Serializable]
	public class PlaceWallStructureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0000AD54 File Offset: 0x00008F54
		[Token(Token = "0x17000413")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0000AD6C File Offset: 0x00008F6C
		[Token(Token = "0x17000414")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0xE51990", Offset = "0xE4FF90", VA = "0x180E51990", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x2F2DE40", Offset = "0x2F2C440", VA = "0x182F2DE40")]
		public PlaceWallStructureModule(ModuleProfileDatabase profileDatabase, ModuleProfileDatabase groundedFakePilarDb, [Optional] IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x2E799A0", Offset = "0x2E77FA0", VA = "0x182E799A0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0000AD84 File Offset: 0x00008F84
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x2F2DF70", Offset = "0x2F2C570", VA = "0x182F2DF70", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x2F2E4C0", Offset = "0x2F2CAC0", VA = "0x182F2E4C0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x2F2E980", Offset = "0x2F2CF80", VA = "0x182F2E980", Slot = "80")]
		protected virtual void AddElement(TargetInfo targetInfo, ModuleProfile profile, WallStructure editingWallStructure)
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x2F2E9B0", Offset = "0x2F2CFB0", VA = "0x182F2E9B0", Slot = "81")]
		protected virtual void SetupWallOnSupport(TargetInfo targetInfo)
		{
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x2F2EC30", Offset = "0x2F2D230", VA = "0x182F2EC30")]
		private void ProcessWallLinking(TargetInfo targetInfo)
		{
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x2F2ECB0", Offset = "0x2F2D2B0", VA = "0x182F2ECB0")]
		private void ProcessCompletedWallLinking(TargetInfo targetInfo)
		{
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x2F2F120", Offset = "0x2F2D720", VA = "0x182F2F120")]
		private List<IWallSupport> GetRightBelowWallSupportsList(WallStructure newWall)
		{
			return null;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x2F2F360", Offset = "0x2F2D960", VA = "0x182F2F360")]
		private void LinkWallToNearbyWallSupports(List<IWallSupport> wallSupportList, WallStructure newWall)
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x2F2F780", Offset = "0x2F2DD80", VA = "0x182F2F780")]
		private List<WallStructure> GetNearbyWallsList(WallStructure newWall)
		{
			return null;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x2F2F9B0", Offset = "0x2F2DFB0", VA = "0x182F2F9B0")]
		private void LinkWallToNearbyWalls(List<WallStructure> nearbyWallList, WallStructure newWall)
		{
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0000AD9C File Offset: 0x00008F9C
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x2F2FB80", Offset = "0x2F2E180", VA = "0x182F2FB80", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x2F2FBE0", Offset = "0x2F2E1E0", VA = "0x182F2FBE0")]
		private bool TryGetPredictedWallSnapPointFromWall(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0000ADCC File Offset: 0x00008FCC
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x2F2FF50", Offset = "0x2F2E550", VA = "0x182F2FF50")]
		private bool TryGetPredictedWallSnapPointFromWallSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x2F303F0", Offset = "0x2F2E9F0", VA = "0x182F303F0")]
		[CompilerGenerated]
		internal static List<BeamStructure> <ProcessCompletedWallLinking>g__GetRightAboveBeam|12_0(WallStructure wall)
		{
			return null;
		}

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly ModuleProfileDatabase _groundedFakePilarProfileDatabase;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ISnapPointValidator _validator;

		// Token: 0x0200024D RID: 589
		[Token(Token = "0x200024D")]
		private class WallPlacementValidator : ISnapPointValidator
		{
			// Token: 0x060011F8 RID: 4600 RVA: 0x0000ADE4 File Offset: 0x00008FE4
			[Token(Token = "0x60011F8")]
			[Address(RVA = "0x2F304F0", Offset = "0x2F2EAF0", VA = "0x182F304F0", Slot = "4")]
			public bool CheckValidTargetPos(PredictedTarget predictedTarget, Vector3 targetPos)
			{
				return default(bool);
			}

			// Token: 0x060011F9 RID: 4601 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60011F9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public WallPlacementValidator()
			{
			}
		}
	}
}
