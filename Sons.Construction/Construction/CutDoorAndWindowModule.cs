using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	public class CutDoorAndWindowModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0000ACAC File Offset: 0x00008EAC
		[Token(Token = "0x1700040F")]
		public override bool AllowsStagingWhileFacingEnemies
		{
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		[Token(Token = "0x17000410")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0000ACDC File Offset: 0x00008EDC
		[Token(Token = "0x17000411")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		[Token(Token = "0x17000412")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x60011DD")]
			[Address(RVA = "0x2E2C3F0", Offset = "0x2E2A9F0", VA = "0x182E2C3F0", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public CutDoorAndWindowModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0000AD0C File Offset: 0x00008F0C
		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x2F2C000", Offset = "0x2F2A600", VA = "0x182F2C000", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x2F2C1E0", Offset = "0x2F2A7E0", VA = "0x182F2C1E0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0000AD24 File Offset: 0x00008F24
		[Token(Token = "0x60011E2")]
		[Address(RVA = "0x2F2C5F0", Offset = "0x2F2ABF0", VA = "0x182F2C5F0")]
		private bool TryGetWindowCutPoint(TargetInfo targetInfo, Vector3 castOrigin, out Vector3 cutPosition, out WallStructure editingWall)
		{
			return default(bool);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0000AD3C File Offset: 0x00008F3C
		[Token(Token = "0x60011E3")]
		[Address(RVA = "0x2F2CA20", Offset = "0x2F2B020", VA = "0x182F2CA20", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x2F2CD50", Offset = "0x2F2B350", VA = "0x182F2CD50", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x2F2CE50", Offset = "0x2F2B450", VA = "0x182F2CE50")]
		private void OnCutWindow(TargetInfo targetInfo)
		{
		}
	}
}
