using System;
using Il2CppDummyDll;

namespace TheForest.Player.Actions
{
	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2000482")]
	public readonly struct PlacementIdentifier
	{
		// Token: 0x06001DCF RID: 7631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public PlacementIdentifier(int itemHeld, int itemNeeded)
		{
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x32E2580", Offset = "0x32E0B80", VA = "0x1832E2580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001C17 RID: 7191
		[Token(Token = "0x4001C17")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _itemHeld;

		// Token: 0x04001C18 RID: 7192
		[Token(Token = "0x4001C18")]
		[FieldOffset(Offset = "0x4")]
		private readonly int _itemNeeded;
	}
}
