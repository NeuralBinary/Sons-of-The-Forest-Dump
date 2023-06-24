using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	public abstract class PlacementModeGroupBase : IPlacementModeGroup
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00004F1C File Offset: 0x0000311C
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700022C")]
		public bool BlockedPlacement
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00004F34 File Offset: 0x00003134
		[Token(Token = "0x1700022D")]
		public int Mode
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x2E34A60", Offset = "0x2E33060", VA = "0x182E34A60", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2E34AD0", Offset = "0x2E330D0", VA = "0x182E34AD0", Slot = "9")]
		public virtual bool TryToggleMode()
		{
			return default(bool);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x66E8E0", Offset = "0x66CEE0", VA = "0x18066E8E0", Slot = "10")]
		public virtual void SetBlockedPlacement()
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x66EAE0", Offset = "0x66D0E0", VA = "0x18066EAE0", Slot = "11")]
		public virtual void UnsetBlockedPlacement()
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2E34B60", Offset = "0x2E33160", VA = "0x182E34B60")]
		protected PlacementModeGroupBase()
		{
		}

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x10")]
		protected readonly List<int> _placementModes;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x18")]
		protected int _currentPlacementModeNum;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x20")]
		protected IPlacementModeGroup _proxyTo;
	}
}
