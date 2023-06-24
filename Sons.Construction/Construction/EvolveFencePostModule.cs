using System;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public class EvolveFencePostModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0000737C File Offset: 0x0000557C
		[Token(Token = "0x170002CE")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00007394 File Offset: 0x00005594
		[Token(Token = "0x170002CF")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x2EA9190", Offset = "0x2EA7790", VA = "0x182EA9190")]
		public EvolveFencePostModule(ModuleProfileDatabase presetDb, BranchingController branchingController)
		{
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x2EA9310", Offset = "0x2EA7910", VA = "0x182EA9310", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x2EA9790", Offset = "0x2EA7D90", VA = "0x182EA9790")]
		private void RefreshPlaceAxisFromPlayer(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000073AC File Offset: 0x000055AC
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x2EA9940", Offset = "0x2EA7F40", VA = "0x182EA9940", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x2EA9B50", Offset = "0x2EA8150", VA = "0x182EA9B50", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x2EAA040", Offset = "0x2EA8640", VA = "0x182EAA040", Slot = "76")]
		protected override void CalcRendererWorldOffset(TargetInfo targetInfo, StructureElement prefab, out Vector3 worldPos, out Quaternion worldRot)
		{
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000073C4 File Offset: 0x000055C4
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x2EAA0D0", Offset = "0x2EA86D0", VA = "0x182EAA0D0", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000073DC File Offset: 0x000055DC
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x2EAA0F0", Offset = "0x2EA86F0", VA = "0x182EAA0F0")]
		private bool TryGetPredictedSnapPointFromFencePost(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x68")]
		private readonly BranchingController _branchingController;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x70")]
		private readonly ModuleProfile _dummyProfile;
	}
}
