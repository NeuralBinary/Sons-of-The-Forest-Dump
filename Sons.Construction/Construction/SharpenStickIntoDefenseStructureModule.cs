using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	public class SharpenStickIntoDefenseStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00008EDC File Offset: 0x000070DC
		[Token(Token = "0x17000359")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00008EF4 File Offset: 0x000070F4
		[Token(Token = "0x1700035A")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x2E2C3F0", Offset = "0x2E2A9F0", VA = "0x182E2C3F0", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public SharpenStickIntoDefenseStructureModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00008F0C File Offset: 0x0000710C
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x2EEA3C0", Offset = "0x2EE89C0", VA = "0x182EEA3C0", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x2EEA8E0", Offset = "0x2EE8EE0", VA = "0x182EEA8E0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00008F24 File Offset: 0x00007124
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x2EEADB0", Offset = "0x2EE93B0", VA = "0x182EEADB0")]
		private bool TryGetSharpenTarget(TargetInfo targetInfo, Vector3 castOrigin, out Vector3 cutPosition, out Vector3 cutAxis, out Structure targetFencePost)
		{
			return default(bool);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00008F3C File Offset: 0x0000713C
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x2EEB1B0", Offset = "0x2EE97B0", VA = "0x182EEB1B0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x2EEB470", Offset = "0x2EE9A70", VA = "0x182EEB470", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
