using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	public class PlaceFenceModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x000076F4 File Offset: 0x000058F4
		[Token(Token = "0x170002DE")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x2EADFE0", Offset = "0x2EAC5E0", VA = "0x182EADFE0")]
		public PlaceFenceModule(ModuleProfileDatabase fenceDb, ModuleProfileDatabase fencePostDb)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x2EAE070", Offset = "0x2EAC670", VA = "0x182EAE070", Slot = "49")]
		public override void SetManager(ConstructionManager manager)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000770C File Offset: 0x0000590C
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x2EAE1C0", Offset = "0x2EAC7C0", VA = "0x182EAE1C0", Slot = "59")]
		protected override bool TryGetStageMessageOverride(ModuleState state, out UiMessages stagedUiMessages)
		{
			return default(bool);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x2EAE240", Offset = "0x2EAC840", VA = "0x182EAE240", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x2EAE770", Offset = "0x2EACD70", VA = "0x182EAE770")]
		private void ShowFencePostDetachedPlacement(ModuleState state, TargetInfo targetInfo)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x2EAF070", Offset = "0x2EAD670", VA = "0x182EAF070")]
		private static void RefreshPlaceAxisFromLookPos(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00007724 File Offset: 0x00005924
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x2EAF1C0", Offset = "0x2EAD7C0", VA = "0x182EAF1C0", Slot = "67")]
		protected override bool CanPlayPlayerPlaceAnim(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x2EAF300", Offset = "0x2EAD900", VA = "0x182EAF300", Slot = "68")]
		public override void Activated(ModuleState state)
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0000773C File Offset: 0x0000593C
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x2D86CB0", Offset = "0x2D852B0", VA = "0x182D86CB0")]
		private static float GetFenceLength()
		{
			return 0f;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00007754 File Offset: 0x00005954
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x2EAF550", Offset = "0x2EADB50", VA = "0x182EAF550")]
		private static bool IsPlacingDetachedFencePost(TargetInfo targetInfo)
		{
			return default(bool);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0000776C File Offset: 0x0000596C
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x2EAF6F0", Offset = "0x2EADCF0", VA = "0x182EAF6F0")]
		private static bool IsPlacingFence(TargetInfo targetInfo)
		{
			return default(bool);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00007784 File Offset: 0x00005984
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x2EAF930", Offset = "0x2EADF30", VA = "0x182EAF930", Slot = "54")]
		public override bool TryValidateProfile(ItemData targetItem, int placementMode, TargetInfo targetInfo, ref ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x2EAFA00", Offset = "0x2EAE000", VA = "0x182EAFA00", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x2EB0160", Offset = "0x2EAE760", VA = "0x182EB0160")]
		private static void CalcFencePosRotFromSupports(TargetInfo targetInfo, out Quaternion rot, out Vector3 snapPos)
		{
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000779C File Offset: 0x0000599C
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x2EB05C0", Offset = "0x2EAEBC0", VA = "0x182EB05C0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000077B4 File Offset: 0x000059B4
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x2EB0620", Offset = "0x2EAEC20", VA = "0x182EB0620")]
		private bool TryGetPredictedSnapPointFromFencePost(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x2EB09F0", Offset = "0x2EAEFF0", VA = "0x182EB09F0")]
		private void LookupNearbyFenceSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos, Structure fenceSupport, ModuleProfile postProfile)
		{
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000077CC File Offset: 0x000059CC
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x2EB1220", Offset = "0x2EAF820", VA = "0x182EB1220")]
		private bool TryGetPredictedSnapPointFromFence(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x2EB15D0", Offset = "0x2EAFBD0", VA = "0x182EB15D0")]
		[CompilerGenerated]
		internal static void <StagedUpdate>g__CalcNextElementPosRot|5_0(out Vector3 elementSnapPos, out Quaternion elementRot, ref PlaceFenceModule.<>c__DisplayClass5_0 A_2)
		{
		}

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x68")]
		private PlaceFenceModule.SnapPointValidator _validator;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] BackForwardDirs;

		// Token: 0x02000182 RID: 386
		[Token(Token = "0x2000182")]
		private class SnapPointValidator : ISnapPointValidator
		{
			// Token: 0x06000BBB RID: 3003 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			public SnapPointValidator(ConstructionManager manager)
			{
			}

			// Token: 0x06000BBC RID: 3004 RVA: 0x000077E4 File Offset: 0x000059E4
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x2EB1950", Offset = "0x2EAFF50", VA = "0x182EB1950", Slot = "4")]
			public bool CheckValidTargetPos(PredictedTarget predictedTarget, Vector3 targetPos)
			{
				return default(bool);
			}

			// Token: 0x06000BBD RID: 3005 RVA: 0x000077FC File Offset: 0x000059FC
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x2EB1C80", Offset = "0x2EB0280", VA = "0x182EB1C80")]
			private static bool CheckDetachedPositionIsFree(Vector3 fromPos, Vector3 detachedPos, out IStructure support)
			{
				return default(bool);
			}

			// Token: 0x0400070F RID: 1807
			[Token(Token = "0x400070F")]
			[FieldOffset(Offset = "0x10")]
			private readonly ConstructionManager _manager;
		}
	}
}
