using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	public class PlaceFurnitureFromTemplateModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00008084 File Offset: 0x00006284
		[Token(Token = "0x170002FF")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0000809C File Offset: 0x0000629C
		[Token(Token = "0x17000300")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x2EC6AC0", Offset = "0x2EC50C0", VA = "0x182EC6AC0")]
		public PlaceFurnitureFromTemplateModule(ModuleProfileDatabase furnitureTemplateDB)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x2EC6B40", Offset = "0x2EC5140", VA = "0x182EC6B40", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x2EC6E50", Offset = "0x2EC5450", VA = "0x182EC6E50", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000080B4 File Offset: 0x000062B4
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x2EC7330", Offset = "0x2EC5930", VA = "0x182EC7330", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000080CC File Offset: 0x000062CC
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x2EC7350", Offset = "0x2EC5950", VA = "0x182EC7350")]
		private bool TryGetPredictedSnapPointFromFencePost(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
