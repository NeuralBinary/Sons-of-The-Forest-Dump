using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	public class PlaceHalfStairsOnWallSideModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0000833C File Offset: 0x0000653C
		[Token(Token = "0x17000316")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x2ECAE70", Offset = "0x2EC9470", VA = "0x182ECAE70", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00008354 File Offset: 0x00006554
		[Token(Token = "0x17000317")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x2ECAE80", Offset = "0x2EC9480", VA = "0x182ECAE80")]
		public PlaceHalfStairsOnWallSideModule(ModuleProfileDatabase halfStairsDb, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x2ECAF20", Offset = "0x2EC9520", VA = "0x182ECAF20", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x2ECB190", Offset = "0x2EC9790", VA = "0x182ECB190", Slot = "61")]
		public override void Unstaged(ModuleProfile profile)
		{
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x2ECB200", Offset = "0x2EC9800", VA = "0x182ECB200", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x2ECB4D0", Offset = "0x2EC9AD0", VA = "0x182ECB4D0")]
		private void SetupHalfStairsFromWall(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0000836C File Offset: 0x0000656C
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x2ECB860", Offset = "0x2EC9E60", VA = "0x182ECB860", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00008384 File Offset: 0x00006584
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x2ECB8C0", Offset = "0x2EC9EC0", VA = "0x182ECB8C0")]
		private bool TryGetPredictedHalfStairSnapPointFromHalfStair(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0000839C File Offset: 0x0000659C
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x2ECBD60", Offset = "0x2ECA360", VA = "0x182ECBD60")]
		private bool TryGetPredictedHalfStairsSnapPointFromWall(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x2ECC5C0", Offset = "0x2ECABC0", VA = "0x182ECC5C0")]
		[CompilerGenerated]
		private void <ShowStagedPreview>g__Draw3dDashesLines|7_0(ref PlaceHalfStairsOnWallSideModule.<>c__DisplayClass7_0 A_1)
		{
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x2ECC900", Offset = "0x2ECAF00", VA = "0x182ECC900")]
		[CompilerGenerated]
		private void <ShowStagedPreview>g__CalcElementWorldPosRot|7_1(Vector3 localPos, Quaternion localRot, out Vector3 elementSnapPos, out Quaternion elementRot, ref PlaceHalfStairsOnWallSideModule.<>c__DisplayClass7_0 A_5)
		{
		}

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x68")]
		private StructureElement _previewTarget;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x70")]
		private Directions _previewDiagonalDir;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Directions[] HalfStairsDirs;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] BottomDiagDirs;
	}
}
