using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	[Serializable]
	public class PlaceDefensiveWallGateStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00006D34 File Offset: 0x00004F34
		[Token(Token = "0x170002A6")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00006D4C File Offset: 0x00004F4C
		[Token(Token = "0x170002A7")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xE59B80", Offset = "0xE58180", VA = "0x180E59B80", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x2E98AB0", Offset = "0x2E970B0", VA = "0x182E98AB0")]
		public PlaceDefensiveWallGateStructureModule(ModuleProfileDatabase profileDatabase, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00006D64 File Offset: 0x00004F64
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x2E98AD0", Offset = "0x2E970D0", VA = "0x182E98AD0", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x2E98CC0", Offset = "0x2E972C0", VA = "0x182E98CC0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00006D7C File Offset: 0x00004F7C
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x2E99120", Offset = "0x2E97720", VA = "0x182E99120")]
		private bool TryGetGateSnapPointFromDefensiveWall(TargetInfo targetInfo, out Vector3 snapPos, out Directions snapDirWall, out Directions snapDirGate, out Directions orientationDir, out DefensiveWallStructure editingDw)
		{
			return default(bool);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x2E99490", Offset = "0x2E97A90", VA = "0x182E99490", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
