using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	public class EvolveFurnitureFromNotchGridModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00007EA4 File Offset: 0x000060A4
		[Token(Token = "0x170002F3")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00007EBC File Offset: 0x000060BC
		[Token(Token = "0x170002F4")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000C48")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x2EC0930", Offset = "0x2EBEF30", VA = "0x182EC0930")]
		public EvolveFurnitureFromNotchGridModule(ModuleProfileDatabase furnitureNotchingDB)
		{
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x2EC09B0", Offset = "0x2EBEFB0", VA = "0x182EC09B0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x2EC0B50", Offset = "0x2EBF150", VA = "0x182EC0B50", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00007ED4 File Offset: 0x000060D4
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x2EC1280", Offset = "0x2EBF880", VA = "0x182EC1280", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00007EEC File Offset: 0x000060EC
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x2EC12A0", Offset = "0x2EBF8A0", VA = "0x182EC12A0")]
		private bool TryGetPredictedSnapPointFromFurniture(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
