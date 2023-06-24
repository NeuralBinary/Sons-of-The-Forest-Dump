using System;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	public class EvolveFurnitureModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00007F04 File Offset: 0x00006104
		[Token(Token = "0x170002F5")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x2EC19D0", Offset = "0x2EBFFD0", VA = "0x182EC19D0")]
		public EvolveFurnitureModule(ModuleProfileDatabase furnitureDb, BranchingController branchingController)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x2EC1AA0", Offset = "0x2EC00A0", VA = "0x182EC1AA0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x2EA9790", Offset = "0x2EA7D90", VA = "0x182EA9790")]
		private void RefreshPlaceAxisFromPlayer(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x2EC2490", Offset = "0x2EC0A90", VA = "0x182EC2490", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x2EAA040", Offset = "0x2EA8640", VA = "0x182EAA040", Slot = "76")]
		protected override void CalcRendererWorldOffset(TargetInfo targetInfo, StructureElement prefab, out Vector3 worldPos, out Quaternion worldRot)
		{
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00007F1C File Offset: 0x0000611C
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x2EC2750", Offset = "0x2EC0D50", VA = "0x182EC2750", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00007F34 File Offset: 0x00006134
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x2EC2770", Offset = "0x2EC0D70", VA = "0x182EC2770")]
		private bool TryGetPredictedSnapPointFromFurniture(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x68")]
		private readonly BranchingController _branchingController;
	}
}
