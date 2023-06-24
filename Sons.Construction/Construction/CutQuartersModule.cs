using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public class CutQuartersModule : ConstructionModule, INonStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x17000202")]
		public override bool AllowsStagingWhileFacingEnemies
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x17000203")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x17000204")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x17000205")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2E2C3F0", Offset = "0x2E2A9F0", VA = "0x182E2C3F0", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public CutQuartersModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2E2D780", Offset = "0x2E2BD80", VA = "0x182E2D780", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2E2D800", Offset = "0x2E2BE00", VA = "0x182E2D800", Slot = "60")]
		public override void StagedUpdate(ModuleState state)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x2E2DF50", Offset = "0x2E2C550", VA = "0x182E2DF50", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2E2E5E0", Offset = "0x2E2CBE0", VA = "0x182E2E5E0")]
		private bool TryGetQuarterCutPoint(ConstructionManager manager, out Vector3 cutPosition, out CutOffQuarters targetCutOff)
		{
			return default(bool);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2E2EA20", Offset = "0x2E2D020", VA = "0x182E2EA20", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2E2F050", Offset = "0x2E2D650", VA = "0x182E2F050")]
		private static bool DestroyCutOffTarget(CutOffQuarters cutOffTarget, out IProtocolToken delayedSwapToken)
		{
			return default(bool);
		}
	}
}
