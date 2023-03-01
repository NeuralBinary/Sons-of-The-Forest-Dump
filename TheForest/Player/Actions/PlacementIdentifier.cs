using System;
using Il2CppDummyDll;

namespace TheForest.Player.Actions
{
	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	public readonly struct PlacementIdentifier
	{
		// Token: 0x06001D8B RID: 7563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x584850", Offset = "0x583850", VA = "0x180584850")]
		public PlacementIdentifier(int itemHeld, int itemNeeded)
		{
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0x2CF5B00", Offset = "0x2CF4B00", VA = "0x182CF5B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001BED RID: 7149
		[Token(Token = "0x4001BED")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _itemHeld;

		// Token: 0x04001BEE RID: 7150
		[Token(Token = "0x4001BEE")]
		[FieldOffset(Offset = "0x4")]
		private readonly int _itemNeeded;
	}
}
