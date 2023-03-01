using System;
using Bolt;
using Il2CppDummyDll;
using UdpKit;

namespace Sons.Inventory
{
	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	public class ItemInstanceBoltDataToken : IProtocolToken
	{
		// Token: 0x0600277E RID: 10110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x2DBBD50", Offset = "0x2DBAD50", VA = "0x182DBBD50", Slot = "4")]
		public void Read(UdpPacket packet)
		{
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x2DBC020", Offset = "0x2DBB020", VA = "0x182DBC020", Slot = "5")]
		public void Write(UdpPacket packet)
		{
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public ItemInstanceBoltDataToken()
		{
		}

		// Token: 0x04002398 RID: 9112
		[Token(Token = "0x4002398")]
		[FieldOffset(Offset = "0x10")]
		public ItemInstance ItemInstance;
	}
}
