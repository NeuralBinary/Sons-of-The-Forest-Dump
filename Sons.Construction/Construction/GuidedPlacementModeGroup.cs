using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public class GuidedPlacementModeGroup : PlacementModeGroupBase
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000229")]
		public IPlacementGuide Current
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x2E34620", Offset = "0x2E32C20", VA = "0x182E34620")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public override void SetBlockedPlacement()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public override void UnsetBlockedPlacement()
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2E34690", Offset = "0x2E32C90", VA = "0x182E34690")]
		public void RegisterCanvasPlacementMode(IPlacementGuide placementGuide)
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2E347A0", Offset = "0x2E32DA0", VA = "0x182E347A0")]
		public GuidedPlacementModeGroup()
		{
		}

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<IPlacementGuide> _placementModeGuides;
	}
}
