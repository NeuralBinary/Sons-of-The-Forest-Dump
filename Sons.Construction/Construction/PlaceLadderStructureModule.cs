using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	[Serializable]
	public class PlaceLadderStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000085C4 File Offset: 0x000067C4
		[Token(Token = "0x17000337")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000D8E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000085DC File Offset: 0x000067DC
		[Token(Token = "0x17000338")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x2ED2E50", Offset = "0x2ED1450", VA = "0x182ED2E50", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x2ED2E60", Offset = "0x2ED1460", VA = "0x182ED2E60")]
		public PlaceLadderStructureModule(ModuleProfileDatabase profileDatabase, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000085F4 File Offset: 0x000067F4
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x2ED2F00", Offset = "0x2ED1500", VA = "0x182ED2F00", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x2ED3230", Offset = "0x2ED1830", VA = "0x182ED3230", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0000860C File Offset: 0x0000680C
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x2ED3600", Offset = "0x2ED1C00", VA = "0x182ED3600")]
		private bool TryGetLadderSnapPointFromWall(TargetInfo targetInfo, ModuleState state, Vector3 castOrigin, out Vector3 snapPos, out Vector3 placeAxis, out LadderStructure editingLadder, out WallStructure support1, out WallDirections supportDir)
		{
			return default(bool);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00008624 File Offset: 0x00006824
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x2ED3E90", Offset = "0x2ED2490", VA = "0x182ED3E90")]
		private bool TryGetLadderSnapPointFromLadder(TargetInfo targetInfo, ModuleState state, out Vector3 snapPos, out Vector3 placeAxis, out LadderStructure editingLadder)
		{
			return default(bool);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x2ED41F0", Offset = "0x2ED27F0", VA = "0x182ED41F0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x2ED4420", Offset = "0x2ED2A20", VA = "0x182ED4420")]
		private void SetupLadder(TargetInfo targetInfo, ModuleProfile profile)
		{
		}
	}
}
