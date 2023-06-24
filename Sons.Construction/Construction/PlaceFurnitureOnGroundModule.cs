using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	[Serializable]
	public class PlaceFurnitureOnGroundModule : PlaceOnGroundModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000080E4 File Offset: 0x000062E4
		[Token(Token = "0x17000301")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x000080FC File Offset: 0x000062FC
		[Token(Token = "0x17000302")]
		protected override bool AllowPlacingOnBuiltGround
		{
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00008114 File Offset: 0x00006314
		[Token(Token = "0x17000303")]
		protected override bool OnFlatGroundOnly
		{
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0000812C File Offset: 0x0000632C
		[Token(Token = "0x17000304")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceFurnitureOnGroundModule(ModuleProfileDatabase db)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00008144 File Offset: 0x00006344
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x2EB25B0", Offset = "0x2EB0BB0", VA = "0x182EB25B0", Slot = "70")]
		public override bool TryValidateTargetInfo(TargetInfo targetInfo, int placementMode)
		{
			return default(bool);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x2EC79E0", Offset = "0x2EC5FE0", VA = "0x182EC79E0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
