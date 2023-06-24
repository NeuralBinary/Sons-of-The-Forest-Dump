using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001CE RID: 462
	[Token(Token = "0x20001CE")]
	[AddComponentMenu("Sons/Construction/CutPilarModule")]
	public class CutPilarModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0000866C File Offset: 0x0000686C
		[Token(Token = "0x1700033A")]
		public override bool AllowsStagingWhileFacingEnemies
		{
			[Token(Token = "0x6000DA3")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00008684 File Offset: 0x00006884
		[Token(Token = "0x1700033B")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0000869C File Offset: 0x0000689C
		[Token(Token = "0x1700033C")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x000086B4 File Offset: 0x000068B4
		[Token(Token = "0x1700033D")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x2E2C3F0", Offset = "0x2E2A9F0", VA = "0x182E2C3F0", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public CutPilarModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000086CC File Offset: 0x000068CC
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x2ED5630", Offset = "0x2ED3C30", VA = "0x182ED5630", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x2E72FE0", Offset = "0x2E715E0", VA = "0x182E72FE0", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x2ED57B0", Offset = "0x2ED3DB0", VA = "0x182ED57B0", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000086E4 File Offset: 0x000068E4
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x2ED59F0", Offset = "0x2ED3FF0", VA = "0x182ED59F0")]
		private bool TryGetPilarCutPoint(TargetInfo targetInfo, out Vector3 cutPosition, out Structure targetPilar, out int quarters)
		{
			return default(bool);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x2ED5F90", Offset = "0x2ED4590", VA = "0x182ED5F90", Slot = "68")]
		public override void Activated(ModuleState state)
		{
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000086FC File Offset: 0x000068FC
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x2ED60F0", Offset = "0x2ED46F0", VA = "0x182ED60F0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x2ED6600", Offset = "0x2ED4C00", VA = "0x182ED6600", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x2ED66A0", Offset = "0x2ED4CA0", VA = "0x182ED66A0")]
		private void OnCutPilar(TargetInfo targetInfo)
		{
		}
	}
}
