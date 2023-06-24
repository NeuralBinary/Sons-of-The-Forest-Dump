using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public class CutDefensiveWallTipModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00006A1C File Offset: 0x00004C1C
		[Token(Token = "0x17000295")]
		public override bool AllowsStagingWhileFacingEnemies
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00006A34 File Offset: 0x00004C34
		[Token(Token = "0x17000296")]
		public override bool AllowsPlaceWhenDamaged
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Token(Token = "0x17000297")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00006A64 File Offset: 0x00004C64
		[Token(Token = "0x17000298")]
		public override UiMessages PlacePromptUiMessages
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x2E2C3F0", Offset = "0x2E2A9F0", VA = "0x182E2C3F0", Slot = "47")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public CutDefensiveWallTipModule(ModuleProfileDatabase profileDatabase)
		{
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00006A7C File Offset: 0x00004C7C
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x2E91260", Offset = "0x2E8F860", VA = "0x182E91260", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x2E91420", Offset = "0x2E8FA20", VA = "0x182E91420", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00006A94 File Offset: 0x00004C94
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2E91750", Offset = "0x2E8FD50", VA = "0x182E91750")]
		private bool TryGetDefensiveWallTipCutPoint(TargetInfo targetInfo, Vector3 castOrigin, out Vector3 cutPosition, out DefensiveWallStructure editingDW)
		{
			return default(bool);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00006AAC File Offset: 0x00004CAC
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x2E91C00", Offset = "0x2E90200", VA = "0x182E91C00")]
		private bool TryGetDefensiveWallTipCutPointFromPilar(TargetInfo targetInfo, Vector3 castOrigin, out Vector3 cutPosition, out PilarStructure editingPilar)
		{
			return default(bool);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x2E921A0", Offset = "0x2E907A0", VA = "0x182E921A0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x2E92560", Offset = "0x2E90B60", VA = "0x182E92560", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x2E92570", Offset = "0x2E90B70", VA = "0x182E92570")]
		private void OnCutDefensiveWallTip(TargetInfo targetInfo)
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x2E92D80", Offset = "0x2E91380", VA = "0x182E92D80")]
		private void CopyRendererRandomRotation(Transform pilarElementTr, Transform dwSpikeTr)
		{
		}
	}
}
