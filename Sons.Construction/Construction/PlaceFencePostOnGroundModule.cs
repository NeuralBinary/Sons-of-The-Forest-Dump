using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	[Serializable]
	public class PlaceFencePostOnGroundModule : PlaceOnGroundModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00007814 File Offset: 0x00005A14
		[Token(Token = "0x170002DF")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0000782C File Offset: 0x00005A2C
		[Token(Token = "0x170002E0")]
		public override bool AllowInCaves
		{
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00007844 File Offset: 0x00005A44
		[Token(Token = "0x170002E1")]
		protected override bool AllowPlacingOnBuiltGround
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0000785C File Offset: 0x00005A5C
		[Token(Token = "0x170002E2")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x2EB2470", Offset = "0x2EB0A70", VA = "0x182EB2470", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x2EB2480", Offset = "0x2EB0A80", VA = "0x182EB2480")]
		public PlaceFencePostOnGroundModule(ModuleProfileDatabase db, IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x2EB24A0", Offset = "0x2EB0AA0", VA = "0x182EB24A0", Slot = "84")]
		protected override void CheckForInvalidPlacement(ModuleState state)
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00007874 File Offset: 0x00005A74
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x2EB25B0", Offset = "0x2EB0BB0", VA = "0x182EB25B0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x2EB25C0", Offset = "0x2EB0BC0", VA = "0x182EB25C0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x2EB2720", Offset = "0x2EB0D20", VA = "0x182EB2720", Slot = "76")]
		protected override void CalcRendererWorldOffset(TargetInfo targetInfo, StructureElement prefab, out Vector3 worldPos, out Quaternion worldRot)
		{
		}
	}
}
