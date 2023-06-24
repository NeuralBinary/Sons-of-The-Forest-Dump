using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public class CutLengthModule : ConstructionModule, INonStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00004B74 File Offset: 0x00002D74
		[Token(Token = "0x170001FE")]
		public override bool AllowsStagingWhileFacingEnemies
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x170001FF")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x17000200")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x17000201")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x2E2C3F0", Offset = "0x2E2A9F0", VA = "0x182E2C3F0", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public CutLengthModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2E2C420", Offset = "0x2E2AA20", VA = "0x182E2C420", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2E2C520", Offset = "0x2E2AB20", VA = "0x182E2C520", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2E2C660", Offset = "0x2E2AC60", VA = "0x182E2C660", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2E2C960", Offset = "0x2E2AF60", VA = "0x182E2C960")]
		private bool TryGetLengthCutPoint(ConstructionManager manager, out Vector3 cutPosition, out CutSplitLength targetCutOff)
		{
			return default(bool);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2E2CD80", Offset = "0x2E2B380", VA = "0x182E2CD80", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2E2D470", Offset = "0x2E2BA70", VA = "0x182E2D470")]
		private static bool DestroyCutOffTarget(CutSplitLength cutOffTarget, out IProtocolToken delayedSwapToken)
		{
			return default(bool);
		}
	}
}
