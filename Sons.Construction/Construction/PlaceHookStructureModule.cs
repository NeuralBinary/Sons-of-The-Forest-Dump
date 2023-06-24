using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	[Serializable]
	public class PlaceHookStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000094DC File Offset: 0x000076DC
		[Token(Token = "0x1700038D")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x000094F4 File Offset: 0x000076F4
		[Token(Token = "0x1700038E")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x2EFC1F0", Offset = "0x2EFA7F0", VA = "0x182EFC1F0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x2EFC200", Offset = "0x2EFA800", VA = "0x182EFC200")]
		public PlaceHookStructureModule(ModuleProfileDatabase profileDatabase, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0000950C File Offset: 0x0000770C
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x2EFC2A0", Offset = "0x2EFA8A0", VA = "0x182EFC2A0", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x2EFC4A0", Offset = "0x2EFAAA0", VA = "0x182EFC4A0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00009524 File Offset: 0x00007724
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x2EFC710", Offset = "0x2EFAD10", VA = "0x182EFC710")]
		private bool TryGetHookSnapPointFromStructure(TargetInfo targetInfo, ModuleState state, Vector3 castOrigin, out Vector3 snapPos, out Vector3 placeAxis, out Structure support)
		{
			return default(bool);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x2EFCB10", Offset = "0x2EFB110", VA = "0x182EFCB10", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x2EFCE30", Offset = "0x2EFB430", VA = "0x182EFCE30")]
		private void SetupHook(TargetInfo targetInfo, ModuleProfile profile)
		{
		}
	}
}
