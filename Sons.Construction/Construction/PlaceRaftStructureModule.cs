using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	[Serializable]
	public class PlaceRaftStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00009854 File Offset: 0x00007A54
		[Token(Token = "0x170003A7")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000FB9")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0000986C File Offset: 0x00007A6C
		[Token(Token = "0x170003A8")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x2EC45D0", Offset = "0x2EC2BD0", VA = "0x182EC45D0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceRaftStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00009884 File Offset: 0x00007A84
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x2F03A50", Offset = "0x2F02050", VA = "0x182F03A50", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x2F03BE0", Offset = "0x2F021E0", VA = "0x182F03BE0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0000989C File Offset: 0x00007A9C
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x2F03F00", Offset = "0x2F02500", VA = "0x182F03F00")]
		private bool TryGetRaftSnapPointFromRaft(TargetInfo targetInfo, ModuleState state, out Vector3 snapPos, out Vector3 placeAxis, out RaftStructure editingRaft)
		{
			return default(bool);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x2F04390", Offset = "0x2F02990", VA = "0x182F04390", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
