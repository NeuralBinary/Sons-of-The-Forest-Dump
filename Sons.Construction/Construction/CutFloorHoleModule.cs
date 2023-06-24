using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	public class CutFloorHoleModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0000788C File Offset: 0x00005A8C
		[Token(Token = "0x170002E3")]
		public override bool AllowsStagingWhileFacingEnemies
		{
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x000078A4 File Offset: 0x00005AA4
		[Token(Token = "0x170002E4")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000078BC File Offset: 0x00005ABC
		[Token(Token = "0x170002E5")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x000078D4 File Offset: 0x00005AD4
		[Token(Token = "0x170002E6")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x2E2C3F0", Offset = "0x2E2A9F0", VA = "0x182E2C3F0", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public CutFloorHoleModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000078EC File Offset: 0x00005AEC
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x2EB27C0", Offset = "0x2EB0DC0", VA = "0x182EB27C0", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x2EB29A0", Offset = "0x2EB0FA0", VA = "0x182EB29A0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00007904 File Offset: 0x00005B04
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x2EB2BE0", Offset = "0x2EB11E0", VA = "0x182EB2BE0")]
		private bool TryGetFloorHoleCutPoint(TargetInfo targetInfo, Vector3 castOrigin, out Vector3 cutPosition, out FloorStructure editingFloor)
		{
			return default(bool);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0000791C File Offset: 0x00005B1C
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x2EB30B0", Offset = "0x2EB16B0", VA = "0x182EB30B0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x2EB3390", Offset = "0x2EB1990", VA = "0x182EB3390", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x2EB33A0", Offset = "0x2EB19A0", VA = "0x182EB33A0")]
		private void OnCutHole(TargetInfo targetInfo)
		{
		}
	}
}
