using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public class PlaceFireOnGroundModule : PlaceOnGroundModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule, ISnapPointPredictingModule
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x000092CC File Offset: 0x000074CC
		[Token(Token = "0x1700037C")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000092E4 File Offset: 0x000074E4
		[Token(Token = "0x1700037D")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x000092FC File Offset: 0x000074FC
		[Token(Token = "0x1700037E")]
		protected override bool AllowPlacingOnBuiltGround
		{
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00009314 File Offset: 0x00007514
		[Token(Token = "0x1700037F")]
		protected override bool OnFlatGroundOnly
		{
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x0000932C File Offset: 0x0000752C
		[Token(Token = "0x17000380")]
		protected override float FlatGroundMinDot
		{
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x2EF98A0", Offset = "0x2EF7EA0", VA = "0x182EF98A0", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x2EF98B0", Offset = "0x2EF7EB0", VA = "0x182EF98B0")]
		public PlaceFireOnGroundModule(ModuleProfileDatabase profileDatabase, ConstructionModule bounceTo, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x2EF9920", Offset = "0x2EF7F20", VA = "0x182EF9920", Slot = "84")]
		protected override void CheckForInvalidPlacement(ModuleState state)
		{
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00009344 File Offset: 0x00007544
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x2EF9A40", Offset = "0x2EF8040", VA = "0x182EF9A40", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x2EF9B50", Offset = "0x2EF8150", VA = "0x182EF9B50", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x2EF9E10", Offset = "0x2EF8410", VA = "0x182EF9E10")]
		private void CreateFireStructure(TargetInfo targetInfo, ModuleProfile profile)
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x2EFA000", Offset = "0x2EF8600", VA = "0x182EFA000")]
		private static void PhysicallyGroundStructure(TargetInfo targetInfo, ModuleProfile profile, Structure presetStructure)
		{
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0000935C File Offset: 0x0000755C
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x2EFA1C0", Offset = "0x2EF87C0", VA = "0x182EFA1C0", Slot = "73")]
		protected override Quaternion GetStructureRotation(TargetInfo targetInfo)
		{
			return default(Quaternion);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x2EFA270", Offset = "0x2EF8870", VA = "0x182EFA270", Slot = "76")]
		protected override void CalcRendererWorldOffset(TargetInfo targetInfo, StructureElement prefab, out Vector3 worldPos, out Quaternion worldRot)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00009374 File Offset: 0x00007574
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x2EFA480", Offset = "0x2EF8A80", VA = "0x182EFA480", Slot = "88")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0000938C File Offset: 0x0000758C
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x2EFA4A0", Offset = "0x2EF8AA0", VA = "0x182EFA4A0")]
		private bool TryGetPredictedFireSnapPointFromSupport(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
