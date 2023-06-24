using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	[Serializable]
	public class PlacePilarOnGroundModule : PlaceOnGroundModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00008B1C File Offset: 0x00006D1C
		[Token(Token = "0x1700034C")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000E03")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00008B34 File Offset: 0x00006D34
		[Token(Token = "0x1700034D")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000E04")]
			[Address(RVA = "0x2EE21B0", Offset = "0x2EE07B0", VA = "0x182EE21B0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x2EE21C0", Offset = "0x2EE07C0", VA = "0x182EE21C0")]
		public PlacePilarOnGroundModule(ModuleProfileDatabase verticalDB, [Optional] IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x2EE2300", Offset = "0x2EE0900", VA = "0x182EE2300", Slot = "87")]
		protected override void ShowDetachedPlacementPreview(TargetInfo targetInfo, ref Vector3 elementSize, ref Vector3 snapPos)
		{
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00008B4C File Offset: 0x00006D4C
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x2EE2840", Offset = "0x2EE0E40", VA = "0x182EE2840", Slot = "82")]
		protected override Vector3 GetPlacePosition(TargetInfo targetInfo)
		{
			return default(Vector3);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x2EE2B50", Offset = "0x2EE1150", VA = "0x182EE2B50", Slot = "83")]
		protected override void GetOverlapCheckSize(ModuleState state, TargetInfo targetInfo, out Vector3 structureProximitySize, out Vector3 sceneryOverlapSize, out Vector3 offset, out Quaternion rot)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00008B64 File Offset: 0x00006D64
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "85")]
		protected override bool UsingAltPlacement(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x2EE2ED0", Offset = "0x2EE14D0", VA = "0x182EE2ED0", Slot = "68")]
		public override void Activated(ModuleState state)
		{
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00008B7C File Offset: 0x00006D7C
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x2EE2F60", Offset = "0x2EE1560", VA = "0x182EE2F60", Slot = "59")]
		protected override bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00008B94 File Offset: 0x00006D94
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x2EE2FC0", Offset = "0x2EE15C0", VA = "0x182EE2FC0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x2EE30C0", Offset = "0x2EE16C0", VA = "0x182EE30C0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00008BAC File Offset: 0x00006DAC
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x2EE35B0", Offset = "0x2EE1BB0", VA = "0x182EE35B0", Slot = "88")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Directions[] PilarDirs;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ISnapPointValidator _nonOrientedSnapPointValidator;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ISnapPointValidator _orientedSnapPointValidator;

		// Token: 0x020001D7 RID: 471
		[Token(Token = "0x20001D7")]
		private class NonOrientedSnapPointValidator : ISnapPointValidator
		{
			// Token: 0x06000E10 RID: 3600 RVA: 0x00008BC4 File Offset: 0x00006DC4
			[Token(Token = "0x6000E10")]
			[Address(RVA = "0x2EE3D90", Offset = "0x2EE2390", VA = "0x182EE3D90", Slot = "4")]
			public bool CheckValidTargetPos(PredictedTarget predictedTarget, Vector3 targetPos)
			{
				return default(bool);
			}

			// Token: 0x06000E11 RID: 3601 RVA: 0x00008BDC File Offset: 0x00006DDC
			[Token(Token = "0x6000E11")]
			[Address(RVA = "0x2EE3F60", Offset = "0x2EE2560", VA = "0x182EE3F60")]
			private static bool CheckDetachedPositionIsFree(Vector3 fromPos, Vector3 detachedPos)
			{
				return default(bool);
			}

			// Token: 0x06000E12 RID: 3602 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000E12")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public NonOrientedSnapPointValidator()
			{
			}
		}

		// Token: 0x020001D8 RID: 472
		[Token(Token = "0x20001D8")]
		private class OrientedSnapPointValidator : ISnapPointValidator
		{
			// Token: 0x06000E13 RID: 3603 RVA: 0x00008BF4 File Offset: 0x00006DF4
			[Token(Token = "0x6000E13")]
			[Address(RVA = "0x2EE4280", Offset = "0x2EE2880", VA = "0x182EE4280", Slot = "4")]
			public bool CheckValidTargetPos(PredictedTarget predictedTarget, Vector3 targetPos)
			{
				return default(bool);
			}

			// Token: 0x06000E14 RID: 3604 RVA: 0x00008C0C File Offset: 0x00006E0C
			[Token(Token = "0x6000E14")]
			[Address(RVA = "0x2EE4490", Offset = "0x2EE2A90", VA = "0x182EE4490")]
			private static bool CheckHasGround(Vector3 placePosTop, float castVerticalOffset, SuperStructure superStructure)
			{
				return default(bool);
			}

			// Token: 0x06000E15 RID: 3605 RVA: 0x00008C24 File Offset: 0x00006E24
			[Token(Token = "0x6000E15")]
			[Address(RVA = "0x2EE4710", Offset = "0x2EE2D10", VA = "0x182EE4710")]
			private static bool HasStructureInTheWay(Vector3 snapPos)
			{
				return default(bool);
			}

			// Token: 0x06000E16 RID: 3606 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000E16")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public OrientedSnapPointValidator()
			{
			}
		}
	}
}
