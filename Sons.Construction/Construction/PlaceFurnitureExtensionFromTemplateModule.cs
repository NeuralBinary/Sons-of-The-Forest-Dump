using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public class PlaceFurnitureExtensionFromTemplateModule : ConstructionModule, ISnapPointPredictingModule, IConstructionModule
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00008024 File Offset: 0x00006224
		[Token(Token = "0x170002FD")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0000803C File Offset: 0x0000623C
		[Token(Token = "0x170002FE")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000C74")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x2EC5A40", Offset = "0x2EC4040", VA = "0x182EC5A40")]
		public PlaceFurnitureExtensionFromTemplateModule(ModuleProfileDatabase furnitureTemplateDB)
		{
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x2EC5AC0", Offset = "0x2EC40C0", VA = "0x182EC5AC0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x2EC6180", Offset = "0x2EC4780", VA = "0x182EC6180", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00008054 File Offset: 0x00006254
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x2EC6520", Offset = "0x2EC4B20", VA = "0x182EC6520", Slot = "77")]
		public bool TryGetPreComputedSnapPoints(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0000806C File Offset: 0x0000626C
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x2EC6540", Offset = "0x2EC4B40", VA = "0x182EC6540")]
		private bool TryGetPredictedSnapPointFromReinforcedFurniture(TargetInfo targetInfo, ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepos)
		{
			return default(bool);
		}
	}
}
